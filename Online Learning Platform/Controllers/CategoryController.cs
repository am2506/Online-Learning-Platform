using Microsoft.AspNetCore.Mvc;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.Repository.Interfaces;

namespace Online_Learning_Platform.Controllers
{
	public class CategoryController : Controller
	{

		private readonly IGenericRepository<Category> _categoryRepository;

		public CategoryController(IGenericRepository<Category> categoryRepository)
		{
			_categoryRepository = categoryRepository;
		}

		public async Task<IActionResult> CategoryIndex()
		{
			IEnumerable<Category> categories = await _categoryRepository.GetWithIncludesAsync(
				c => c.Courses
			);
			return View(categories);
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
