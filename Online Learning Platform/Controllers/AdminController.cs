using Microsoft.AspNetCore.Mvc;
using Online_Learning_Platform.Models.Data;
using Online_Learning_Platform.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Online_Learning_Platform.Models.ViewModels;
using Online_Learning_Platform.ViewModels;
using static Online_Learning_Platform.Helpers.DocumentSettings;


public class AdminController : Controller
{
    private readonly ApplicationDbContext _context;
    public AdminController(ApplicationDbContext context)
    {
        _context = context;
    }



    // Admin Dashboard Home Page
    //public async Task<IActionResult> Index()
    //{
    //    var dashboardData = new DashboardViewModel
    //    {
    //        TotalUsers = await _context.Users.CountAsync(),
    //        TotalCourses = await _context.Courses.Include(c => c.Category).CountAsync(),
    //        TotalEnrollments = await _context.Enrollments.CountAsync(),
    //        TotalCategories = await _context.Categories.CountAsync(),
    //    };

    //    return View(dashboardData);
    //}
    public async Task<IActionResult> Index()
    {
        var dashboardData = new DashboardViewModel
        {
            // Summary data
            TotalUsers = await _context.Users.CountAsync(),
            TotalCourses = await _context.Courses.Include(c => c.Category).CountAsync(),
            TotalEnrollments = await _context.Enrollments.CountAsync(),
            TotalCategories = await _context.Categories.CountAsync(),

            // Data for User Roles Chart
            UserRoles = await _context.Users.GroupBy(u => u.RoleName)
                .Select(g => g.Key).ToListAsync(),
            RoleCounts = await _context.Users.GroupBy(u => u.RoleName)
                .Select(g => g.Count()).ToListAsync(),

            // Data for Courses by Category Chart
            Categories = await _context.Courses.GroupBy(c => c.Category.Name)
                .Select(g => g.Key).ToListAsync(),
            CategoryCounts = await _context.Courses.GroupBy(c => c.Category.Name)
                .Select(g => g.Count()).ToListAsync(),

            // Data for Course Enrollment Counts
            CourseTitles = await _context.Courses.Select(c => c.Title).ToListAsync(),
            CourseEnrollmentCounts = await _context.Courses
                .Select(c => c.Enrollments.Count).ToListAsync(),

            // Data for Enrollment Trends by Date
            EnrollmentDates = await _context.Enrollments
                .GroupBy(e => e.EnrollmentDate.Date)
                .Select(g => g.Key.ToShortDateString()).ToListAsync(),
            DailyEnrollments = await _context.Enrollments
                .GroupBy(e => e.EnrollmentDate.Date)
                .Select(g => g.Count()).ToListAsync()
        };

        return View(dashboardData);
    }


    #region Courses
    // Load categories and instructors for the dropdown lists
    private void LoadCategoriesAndInstructors()
    {
        ViewBag.Categories = new SelectList(_context.Categories, "Id", "Name");
        ViewBag.Instructors = new SelectList(_context.Instructors, "Id", "Name");
    }

    // Manage Courses
    private void LoadCategoriesAndInstructors(CourseViewModel model)
    {

        model.Categories = _context.Categories.Select(c => new SelectListItem
        {
            Value = c.Id.ToString(),
            Text = c.Name
        }).ToList();

        model.Instructors = _context.Users
            .Where(u => u.RoleName == "Instructor")
            .Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = u.UserName
            }).ToList();
    }
    public IActionResult Courses()
    {
        var courses = _context.Courses
            .Include(c => c.Category)
            .Include(c => c.Instructor)
            .Select(c => new CourseViewModel
            {
                Id = c.Id,
                Title = c.Title,
                Description = c.Description,
                CategoryId = c.CategoryId,
                InstructorId = c.InstructorId,
                Duration = c.Duration,
                TotalLecture = c.TotalLecture
            }).ToList();

        return View(courses);
    }

    [HttpGet]
    public IActionResult AddCourse()
    {
        var model = new CourseViewModel();


        LoadCategoriesAndInstructors(model);

        return View(model);
    }


    [HttpPost]
    public IActionResult AddCourse(CourseViewModel model)
    {
        if (ModelState.IsValid)
        {
            string imagePath = null;

            // Check if an image file was uploaded
            if (model.ImageFile != null)
            {
                // Generate a unique file name for the image and save it to wwwroot/images folder
                var fileName = Path.GetFileNameWithoutExtension(model.ImageFile.FileName);
                var extension = Path.GetExtension(model.ImageFile.FileName);
                fileName = $"{fileName}_{DateTime.Now:yyyyMMddHHmmss}{extension}";
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    model.ImageFile.CopyTo(stream);
                }

                imagePath = "/images/" + fileName;  // Path for the image to be used in the view
            }

            var course = new Course
            {
                Title = model.Title,
                Description = model.Description,
                ImageUrl = imagePath,
                Duration = model.Duration,
                TotalLecture = model.TotalLecture,
                CategoryId = model.CategoryId,
                InstructorId = model.InstructorId
            };

            _context.Courses.Add(course);
            _context.SaveChanges();

            return RedirectToAction("Courses");
        }

        // Add logging to check for validation errors
        foreach (var value in ModelState.Values)
        {
            foreach (var error in value.Errors)
            {
                Console.WriteLine("Validation Error: " + error.ErrorMessage);
            }
        }

        LoadCategoriesAndInstructors(model);  // Reload dropdowns if there are validation errors
        return View(model);  // Re-display form with validation errors
    }


    [HttpGet]
    public IActionResult EditCourse(int id)
    {

        var course = _context.Courses.Find(id);
        if (course == null)
        {
            return NotFound();
        }


        var model = new CourseViewModel
        {
            Id = course.Id,
            Title = course.Title,
            Description = course.Description,
            ImageUrl = course.ImageUrl,
            Duration = course.Duration,
            TotalLecture = course.TotalLecture,
            CategoryId = course.CategoryId,
            InstructorId = course.InstructorId
        };

        LoadCategoriesAndInstructors(model);

        return View(model);
    } 

    [HttpPost]
    public IActionResult EditCourse(CourseViewModel model)
    {
        if (ModelState.IsValid)
        {
            var course = _context.Courses.Find(model.Id);

            if (course == null)
            {
                return NotFound();
            }

            string imagePath = course.ImageUrl;  // Preserve existing image path

            // If a new image file was uploaded, save the new image and update the path
            if (model.ImageFile != null)
            {
                var fileName = Path.GetFileNameWithoutExtension(model.ImageFile.FileName);
                var extension = Path.GetExtension(model.ImageFile.FileName);
                fileName = $"{fileName}_{DateTime.Now:yyyyMMddHHmmss}{extension}";
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    model.ImageFile.CopyTo(stream);
                }

                imagePath = "/images/" + fileName;
            }
            // Update the course details
            course.Title = model.Title;
            course.Description = model.Description;
            course.ImageUrl = imagePath;
            course.Duration = model.Duration;
            course.TotalLecture = model.TotalLecture;
            course.CategoryId = model.CategoryId;
            course.InstructorId = model.InstructorId;

            _context.Courses.Update(course);
            _context.SaveChanges();

            return RedirectToAction("Courses");
        }

        LoadCategoriesAndInstructors(model);
        return View(model);
    }

    // Delete Course
    public IActionResult DeleteCourse(int id)
    {
        var course = _context.Courses.Find(id);
        if (course == null) return NotFound();

        _context.Courses.Remove(course);
        _context.SaveChanges();
        return RedirectToAction("Courses");
    }

    #endregion
 
    #region Users
    // List All Users
    public IActionResult Users()
    {
        var users = _context.Users.ToList();
        return View(users);
    }

    // Add User

    [HttpGet]
    public IActionResult AddUser(int? id)
    {
        if (id == null)
        {
            return View(new UserBase()); // Empty UserBase for adding new user
        }
        var user = _context.Users.Find(id);
        if (user == null)
        {
            return NotFound();
        }
        return View(user);
    }

    [HttpPost]
    public IActionResult AddUser(UserBase user)
    {
        if (ModelState.IsValid)
        {
            var users = _context.Users.ToList(); // Load all users

            if (user.Id == 0)
            {
                _context.Users.Add(user); // Create new user
            }
            else
            {
                _context.Users.Update(user); // Edit existing user
            }
            _context.SaveChanges();
            return RedirectToAction("Users", users);
        }

        return View(user);
    }

    // Edit User
    [HttpGet]
    public async Task<IActionResult> EditUser(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null)
        {
            return NotFound();
        }
        return View(user);
    }

    [HttpPost]
    public async Task<IActionResult> EditUser(UserBase user)
    {
        if (ModelState.IsValid)
        {
            var existingUser = await _context.Users.FindAsync(user.Id);
            if (existingUser == null)
            {
                return NotFound();
            }

            // Update properties
            existingUser.UserName = user.UserName;
            existingUser.Email = user.Email;
            existingUser.RoleName = user.RoleName;

            _context.Users.Update(existingUser);
            await _context.SaveChangesAsync();

            return RedirectToAction("Users");
        }

        return View(user);
    }



    // Delete User
    public IActionResult DeleteUser(int id)
    {
        var user = _context.Users.Find(id);
        if (user == null) return NotFound();

        _context.Users.Remove(user);
        _context.SaveChanges();
        return RedirectToAction("Users");
    }
    #endregion

    #region Categories
    // Manage Categories
    public IActionResult Categories()
    {
        var categories = _context.Categories
            .Select(c => new CategoryViewModel
            {
                Id = c.Id,
                Name = c.Name
            })
            .ToList();

        return View(categories);
    }

    [HttpGet]
    public IActionResult AddCategory(int? id)
    {
        if (id == null)
        {
            return View(new CategoryViewModel()); // Empty model for adding a new category
        }

        var category = _context.Categories.Find(id);
        if (category == null)
        {
            return NotFound();
        }

        var model = new CategoryViewModel
        {
            Id = category.Id,
            Name = category.Name
        };

        return View(model);
    }

    [HttpPost]
    public IActionResult AddCategory(CategoryViewModel model)
    {
        if (ModelState.IsValid)
        {
            if (model.Id == 0)
            {
                var newCategory = new Category
                {
                    Name = model.Name
                };

                _context.Categories.Add(newCategory);
            }
            else
            {
                var existingCategory = _context.Categories.Find(model.Id);
                if (existingCategory == null)
                {
                    return NotFound();
                }

                existingCategory.Name = model.Name;
                _context.Categories.Update(existingCategory);
            }

            _context.SaveChanges();

            return RedirectToAction("Categories");
        }

        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> EditCategory(int id)
    {
        var category = await _context.Categories.FindAsync(id);
        if (category == null)
        {
            return NotFound();
        }

        var model = new CategoryViewModel
        {
            Id = category.Id,
            Name = category.Name
        };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> EditCategory(CategoryViewModel model)
    {
        if (ModelState.IsValid)
        {
            var category = await _context.Categories.FindAsync(model.Id);
            if (category == null)
            {
                return NotFound();
            }

            category.Name = model.Name;

            _context.Categories.Update(category);
            await _context.SaveChangesAsync();

            return RedirectToAction("Categories");
        }

        return View(model);
    }

    public IActionResult DeleteCategory(int id)
    {
        var category = _context.Categories.Find(id);
        if (category == null)
        {
            return NotFound();
        }

        _context.Categories.Remove(category);
        _context.SaveChanges();
        return RedirectToAction("Categories");
    }

    #endregion
   
    #region Enrollments
    // View Enrollments by Course
    public IActionResult Enrollments(int courseId)
    {
        var enrollments = _context.Enrollments
                                  .Include(e => e.Course)
                                  .Include(e => e.Student)
                                  .Select(e => new EnrollmentViewModel
                                  {
                                      EnrollmentId = e.StudentId,
                                      CourseTitle = e.Course.Title,
                                     // StudentUserName = e.Student.UserName,
                                      Progress = e.Prograss,
                                      EnrollmentDate = e.EnrollmentDate
                                  })
                                  .ToList();
        LoadCoursesAndStudents();

        return View(enrollments);
    }

    private void LoadCoursesAndStudents()
    {
        var courses = _context.Courses.ToList() ?? new List<Course>();
        var students = _context.Students.ToList() ?? new List<Student>();

        ViewBag.Courses = new SelectList(courses, "Id", "CourseName");
        ViewBag.Students = new SelectList(students, "Id", "FullName");
    }
    [HttpGet]
    public IActionResult AddEnrollment()
    {
        LoadCoursesAndStudents(); // Helper method to load available courses and students
        return View(new Enrollment()); // Return an empty enrollment object
    }
    [HttpPost]
    public IActionResult AddEnrollment(Enrollment enrollment)
    {
        if (ModelState.IsValid)
        {
            _context.Enrollments.Add(enrollment); // Add new enrollment
            _context.SaveChanges();
            return RedirectToAction("Enrollments", new { courseId = enrollment.CourseId });
        }

        LoadCoursesAndStudents(); // Reload dropdowns in case of validation error
        return View(enrollment);
    }
    [HttpGet]
    public IActionResult EditEnrollment(int id)
    {
        var enrollment = _context.Enrollments.Find(id);
        if (enrollment == null) return NotFound();

        LoadCoursesAndStudents(); // Load course and student dropdowns
        return View(enrollment);
    }
    [HttpPost]
    public IActionResult EditEnrollment(Enrollment enrollment)
    {
        if (ModelState.IsValid)
        {
            _context.Enrollments.Update(enrollment); // Update existing enrollment
            _context.SaveChanges();
            return RedirectToAction("Enrollments", new { courseId = enrollment.CourseId });
        }

        LoadCoursesAndStudents(); // Reload dropdowns in case of validation error
        return View(enrollment);
    }

    public IActionResult DeleteEnrollment(int id)
    {
        var enrollment = _context.Enrollments.Find(id);
        if (enrollment == null) return NotFound();

        _context.Enrollments.Remove(enrollment); // Remove the enrollment
        _context.SaveChanges();
        return RedirectToAction("Enrollments", new { courseId = enrollment.CourseId });
    }
    #endregion

    
   


}

