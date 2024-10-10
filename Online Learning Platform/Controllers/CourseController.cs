using Microsoft.AspNetCore.Mvc;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.Repository.Interfaces;
using Online_Learning_Platform.Repository.Repository;

namespace Online_Learning_Platform.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _coursesRepo;

        public CourseController(ICourseRepository coursesRepo)
        {
            _coursesRepo = coursesRepo;
        }

        public async Task<IActionResult> Index(string ?SearchItem)
        {
            var courses = Enumerable.Empty<Course>();
            if (string.IsNullOrEmpty(SearchItem))
            {
                courses = await _coursesRepo.GetAllCoursesAsync();
            }
            else
            {
                courses = _coursesRepo.SearchByNameAsync(SearchItem);
            }
            return View(courses);
            
        }
		public IActionResult MyCourses(int Id)
		{
			var UserCourses = _coursesRepo.CoursesOfUser(Id);
			return View(UserCourses);
		}
	}
}
