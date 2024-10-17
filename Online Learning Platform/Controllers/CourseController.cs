using Microsoft.AspNetCore.Mvc;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.Repository.Interfaces;
using Online_Learning_Platform.Repository.Repository;
using Online_Learning_Platform.ViewModels;

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


        public async Task<IActionResult> Index(string searchTerm, int? categoryId)
        {
			IEnumerable<Course> courses;
			courses = await _courseRepository.GetWithIncludesAsync(
				c => c.Instructor,
				c => c.Category
			);

			

			if (categoryId.HasValue)
			{
				courses = courses.Where(c => c.CategoryId == categoryId.Value);
			}

			if (!string.IsNullOrEmpty(searchTerm))
			{
				courses = courses.Where(c => c.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
											  (c.Instructor.FirstName + " " + c.Instructor.LastName).Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
											  c.Category.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
				);
			}

			var viewModel = new CourseIndexViewModel
			{
				Courses = courses,
				Categories = await _categoryRepository.GetAllAsync() // Assuming you have this method
			};

			return View(viewModel);
		}

        public async Task<IActionResult> CategoryIndex()
        {
            IEnumerable<Category> categories = await _categoryRepository.GetWithIncludesAsync(
                c => c.Courses
            );
            return View(categories);
        }

		//public async Task<IActionResult> InstructorIndex()
		//{
		//	IEnumerable<Instructor> instructors = await _instructorRepository.GetWithIncludesAsync(
		//		c => c.Courses
		//	);
		//	return View(instructors);
		//}

	}

}
