using Microsoft.AspNetCore.Mvc;
using Online_Learning_Platform.Repository.Interfaces;
using Online_Learning_Platform.ViewModels;

namespace Online_Learning_Platform.Controllers
{
    public class StudentController : Controller
    {
        private readonly IUserRepository _userRepository;

        public StudentController(IUserRepository userRepository )
        {
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        //=========== Profile Detalis =============
        #region ProfileDetails
        public async Task<IActionResult> StudentProfile(string UserName)
        {
            var user = await _userRepository.GetUserByUserName(UserName);
            if (user == null)
            {
                return NotFound();
            }
            var profile = new ProfileDetialsViewModel
            {

                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };
            return View(profile);
        }
        #endregion

        //=========== My Courses =============
        

    }
}
