using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.Models.Data;
using Online_Learning_Platform.Models.ViewModels;
using Online_Learning_Platform.ViewModels;

namespace Online_Learning_Platform.Controllers
{
    public class UsesrManagementController : Controller
    {
        #region Constractor
        private readonly ApplicationDbContext _context;
        private readonly UserManager<UserBase> _userManager;

        public UsesrManagementController(ApplicationDbContext context, UserManager<UserBase> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        #endregion
        
        // Admin Dashboard Home Page
        public async Task<IActionResult> Index()
        {
            var dashboardData = new DashboardViewModel
            {
                TotalUsers = await _userManager.Users.CountAsync(),
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
            return RedirectToAction();
        }
    }
}
