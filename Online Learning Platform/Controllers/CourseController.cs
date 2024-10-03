using Microsoft.AspNetCore.Mvc;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.Repository.Interfaces;

namespace Online_Learning_Platform.Controllers
{
    public class CourseController : Controller
    {
        private readonly IGenericRepository<Course> _courseRepository;
        private readonly IGenericRepository<Category> _categoryRepository;
		private readonly IGenericRepository<Instructor> _instructorRepository;

		public CourseController(IGenericRepository<Course> courseRepository, IGenericRepository<Category> categoryRepository, IGenericRepository<Instructor> instructorRepository)
        {
            _courseRepository = courseRepository;
            _categoryRepository = categoryRepository;
            _instructorRepository = instructorRepository;
        }

        public async Task<IActionResult> Index(string searchTerm)
        {
			IEnumerable<Course> courses;
			if (!string.IsNullOrEmpty(searchTerm))
			{
				courses = await _courseRepository.GetWithIncludesAsync(
					c => c.Instructor,
					c => c.Category
				);

				courses = courses.Where(c => c.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
											 (c.Instructor.FirstName + " " + c.Instructor.LastName).Contains(searchTerm, StringComparison.OrdinalIgnoreCase)||
											 c.Category.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
				);
			}
			else
			{
				courses = await _courseRepository.GetWithIncludesAsync(
					c => c.Instructor,
					c => c.Category
				);
			}
			return View(courses);
        }

        public async Task<IActionResult> CategoryIndex()
        {
            IEnumerable<Category> categories = await _categoryRepository.GetWithIncludesAsync(
                c => c.Courses
            );
            return View(categories);
        }

		public async Task<IActionResult> InstructorIndex()
		{
			IEnumerable<Instructor> instructors = await _instructorRepository.GetWithIncludesAsync(
				c => c.Courses
			);
			return View(instructors);
		}

	}
}
