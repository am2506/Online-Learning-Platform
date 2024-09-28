using Microsoft.AspNetCore.Mvc;
using Online_Learning_Platform.Repository.Interfaces;

namespace Online_Learning_Platform.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _coursesRepo;

        public CourseController(ICourseRepository coursesRepo)
        {
            _coursesRepo = coursesRepo;
        }

        public async Task<IActionResult> Index()
        {
            var courses = await _coursesRepo.GetAllCoursesAsync();
            return View(courses);
        }
    }
}
