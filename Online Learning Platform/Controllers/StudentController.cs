using Microsoft.AspNetCore.Mvc;
using Online_Learning_Platform.Helpers;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.Repository.Interfaces;
using Online_Learning_Platform.ViewModels;
using static Online_Learning_Platform.Helpers.DocumentSettings;

namespace Online_Learning_Platform.Controllers
{
    public class StudentController : Controller
    {
        private readonly IUserRepository _userRepository;
        public StudentController(IUserRepository userRepository )
        {
            _userRepository = userRepository;
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
                Id = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                ImageUrl = user.ImageUrl
            };
            return View(profile);
        }
        #endregion

        #region Update Student
        public async Task<IActionResult> UpdateProfile(string UserName)
        {
            // Await the result of StudentProfile
            var profile = await StudentProfile(UserName) as ViewResult;

            if (profile?.Model is ProfileDetialsViewModel model)
            {
                return View(model);
            }

            return NotFound();
        }
        
        [HttpPost]
        public async Task<IActionResult> UpdateProfile(ProfileDetialsViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Handle the image upload if the image was uploaded
                string fileName = null;
                if (model.ProfileImage != null)
                {
                    fileName = UploadFile(model.ProfileImage, "UserImages");
                }

                // If UserName is null, get it from TempData
                if (model.UserName == null)
                    model.UserName = TempData["UserName"].ToString();

                var user = await _userRepository.GetUserByUserName(model.UserName);
                if (user == null)
                {
                    return NotFound();
                }

                // Update user properties
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Email = model.Email;
                user.PhoneNumber = model.PhoneNumber??null;

                // If a new image was uploaded, update the ImageUrl
                if (!string.IsNullOrEmpty(fileName))
                {
                    user.ImageUrl = fileName;
                }

                // Update the user in the repository
                try
                {
                    var result = await _userRepository.UpdateUser(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("StudentProfile", new { UserName = user.UserName });
                    }
                    else
                    {
                        ModelState.AddModelError("", "Update failed, Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            return View(model);
        }

        #endregion

        #region Track Prograss





        #endregion
    }
}
