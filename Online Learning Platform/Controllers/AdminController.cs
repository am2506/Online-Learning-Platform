using Microsoft.AspNetCore.Mvc;
using Online_Learning_Platform.Models.Data;
using Online_Learning_Platform.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Online_Learning_Platform.Models.ViewModels;
using Online_Learning_Platform.ModelBL;
using Microsoft.AspNetCore.Identity;
using Online_Learning_Platform.ViewModels;

public class AdminController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<UserBase> _userManager;

    public AdminController(ApplicationDbContext context, UserManager<UserBase> userManager)
    {
        _context = context;
       _userManager = userManager;
    }
    //============= User Management =============
    #region UserManagement
    // Admin Dashboard Home Page
    public async Task<IActionResult> Index()
    {
        var dashboardData = new DashboardViewModel
        {
            TotalUsers = await _context.Users.CountAsync(),
            TotalCourses = await _context.Courses.Include(c => c.Category).CountAsync(),
            TotalEnrollments = await _context.Enrollments.CountAsync(),
            TotalCategories = await _context.Categories.CountAsync(),
        };

        return View(dashboardData);
    }

    // List All Users
    public IActionResult Users()
    {
        var users = _userManager.Users.ToList();
        return View(users);
    }

    // Add User
    [HttpGet]
    public async Task<IActionResult> AddUser(int? id)
    {
        if (id == null)
        {
            return View(new UserBase()); // Empty UserBase for adding new user
        }
        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user == null)
        {
            return NotFound();
        }
        return View(user);
    }
    [HttpPost]
    public async Task<IActionResult> AddUser(AddUserViewModel user)
    {
        if (ModelState.IsValid)
        {
            var userExists = _userManager.FindByEmailAsync(user.Email);
            if (userExists != null)
            {
                ModelState.AddModelError("Email", "Email already exists");
                return View(user);
            }
            var NewUser = new UserBase
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                RoleName = user.RoleName
            };
            try
            {
                var Result = await _userManager.CreateAsync(NewUser, user.Password);
                if (Result.Succeeded)
                {
                    Result = await _userManager.AddToRoleAsync(NewUser, user.RoleName);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(user);
            }
          
            
            return RedirectToAction("Users");
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

    //============= Course Management =============
    #region Course Management
    // Manage Courses
    public IActionResult Courses()
    {
        //var courses = _context.Courses.Include(c => c.Category).Include(c => c.Instructor).ToList();

        var courses = _context.Courses.ToList();
        return View(courses);
    }
    // Add Course
    [HttpGet]
    public IActionResult AddCourse(int? id)
    {
        LoadCategoriesAndInstructors();  // Ensure dropdowns are populated

        if (id == null)
        {
            return View(new Course()); // Return empty course for creation
        }

        var course = _context.Courses.Find(id);
        if (course == null)
        {
            return NotFound();
        }

        return View(course);
    }

    [HttpPost]
    public IActionResult AddCourse(Course course)
    {
        if (ModelState.IsValid)
        {

            if (course.Id == 0)
            {
                _context.Courses.Add(course); // Add new course
            }
            else
            {
                _context.Courses.Update(course); // Update existing course
            }
            _context.SaveChanges();
            return RedirectToAction("Courses");
        }

        LoadCategoriesAndInstructors();  // Reload dropdowns in case of validation error
        return View(course);
    }

    [HttpGet]
    public IActionResult EditCourse(int? id)
    {
        if (id == null) return NotFound();

        var course = _context.Courses.Find(id);
        if (course == null) return NotFound();

        LoadCategoriesAndInstructors();
        return View(course);
    }

    // Similarly for EditCourse
    [HttpPost]
    public IActionResult EditCourse(Course course)
    {
        if (ModelState.IsValid)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
            return RedirectToAction("Courses");
        }

        LoadCategoriesAndInstructors();  // Reload dropdowns in case of validation error
        return View(course);
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

    //============= Category Management =============
    #region Category Management
    // Manage Categories
    public IActionResult Categories()
    {
        var categories = _context.Categories.ToList();
        return View(categories);
    }
    [HttpGet]
    public IActionResult AddCategory(int? id)
    {
        if (id == null)
        {
            return View(new Category()); // Empty UserBase for adding new user
        }
        var Category = _context.Categories.Find(id);
        if (Category == null)
        {
            return NotFound();
        }
        return View(Category);
    }

    [HttpPost]
    public IActionResult AddCategory(Category category)
    {
        if (ModelState.IsValid)
        {
            if (category.Id == 0)
            {
                _context.Categories.Add(category); // Create new category
            }
            else
            {
                _context.Categories.Update(category); // Edit existing category
            }

            _context.SaveChanges();

            // Redirect to prevent form resubmission
            return RedirectToAction("Categories"); // Redirect to the list of categories
        }

        return View(category); // If validation fails, return the same view with errors
    }

    // Edit Category
    [HttpGet]
    public async Task<IActionResult> EditCategory(int id)
    {
        var Category = await _context.Categories.FindAsync(id);
        if (Category == null)
        {
            return NotFound();
        }
        return View(Category);
    }

    [HttpPost]
    public async Task<IActionResult> EditCategory(Category Category)
    {
        if (ModelState.IsValid)
        {
            var existingCategory = await _context.Categories.FindAsync(Category.Id);
            if (existingCategory == null)
            {
                return NotFound();
            }

            // Update properties
            existingCategory.Name = Category.Name;


            _context.Categories.Update(existingCategory);
            await _context.SaveChangesAsync();

            return RedirectToAction("Categories");
        }

        return View(Category);
    }
    // Delete User
    public IActionResult DeleteCategory(int id)
    {
        var Category = _context.Categories.Find(id);
        if (Category == null) return NotFound();

        _context.Categories.Remove(Category);
        _context.SaveChanges();
        return RedirectToAction("Categories");
    }
    #endregion
    //============= Enrollment Management =============
    #region EnrollmentManagement
    // View Enrollments by Course
    public IActionResult Enrollments(int courseId)
    {
        var enrollments = _context.Enrollments;
        //var enrollments = _context.Enrollments.Where(e => e.CourseId == courseId)
        //                                      .Include(e => e.Student)
        //                                      .ToList();
        return View(enrollments);
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



    // Helper function to load Categories and Instructors for the views
    private void LoadCoursesAndStudents()
    {
        var courses = _context.Courses.ToList() ?? new List<Course>();
       //var students = _context.Students.ToList() ?? new List<Student>();

        ViewBag.Courses = new SelectList(courses, "Id", "CourseName");
       // ViewBag.Students = new SelectList(students, "Id", "FullName");
    }
    private void LoadCategoriesAndInstructors()
    {
        var categories = _context.Categories.ToList() ?? new List<Category>();
        //var instructors = _context.Instructors.ToList() ?? new List<Instructor>();

        ViewBag.Categories = new SelectList(categories, "Id", "Name");
        //ViewBag.Instructors = new SelectList(instructors, "Id", "Name");
    }


}
