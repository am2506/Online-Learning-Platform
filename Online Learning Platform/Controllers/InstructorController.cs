using Microsoft.AspNetCore.Mvc;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.Repository.Interfaces;

namespace Online_Learning_Platform.Controllers
{
	public class InstructorController : Controller
	{
		private readonly IGenericRepository<Instructor> _instructorRepository;

		public InstructorController(IGenericRepository<Instructor> instructorRepository)
		{
			_instructorRepository = instructorRepository;
		}
		public IActionResult GetInstructorInfo(int id)
		{

			return View(_instructorRepository.GetByIdAsync(id));
		}
		public async Task<IActionResult> InstructorIndex()
		{
			IEnumerable<Instructor> instructors = await _instructorRepository.GetWithIncludesAsync(
				c => c.Courses
			);
			return View(instructors);
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
