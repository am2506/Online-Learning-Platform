using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Online_Learning_Platform.Helpers;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.ViewModels;
using System.Drawing.Drawing2D;

namespace Online_Learning_Platform.Controllers
{
	public class AuthController : Controller
	{
		#region Constructor
		private readonly UserManager<UserBase> _userManager;
		private readonly SignInManager<UserBase> _signInManager;

		public AuthController(UserManager<UserBase> userManager, SignInManager<UserBase> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}
		#endregion
		//================Sign in Region ===============
		#region SignIn
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(LoginViewModel model)
		{
			if (!ModelState.IsValid)
				return View(model);

			var userExist = await _userManager.FindByEmailAsync(model.Email);
			if (userExist is not null)
			{
				var checkPassword = await _signInManager.PasswordSignInAsync(userExist, model.Password, model.RememberMe, false);
				if (checkPassword.Succeeded)
				{

					TempData["name"] = $"{userExist.FirstName} {userExist.LastName}";
					TempData["img"] = "~/images/person_2.jpg";

					return RedirectToAction("Index", "Home");
				}
					
			}
			ModelState.AddModelError("", "Invalid Email or Password");
			return View();
		}
		#endregion
		//============== Sign up Region ================	
		#region SignUp
		public IActionResult SignUp()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> SignUp(SignUpViewModel model, string Role = "Student")
		{
			try
			{
				if (!ModelState.IsValid)
					return View(model);

				var userExist = await _userManager.FindByEmailAsync(model.Email);
				if (userExist is not null)
				{
					ModelState.AddModelError("Email", "Email is already exist");
					return View(model);
				}

				var user = new UserBase
				{
					FirstName = model.FirstName,
					LastName = model.LastName,
					Email = model.Email,
					UserName = model.Email.Split('@')[0]
				};
				var NewUser = await _userManager.CreateAsync(user, model.Password);
				if (NewUser.Succeeded)
				{
					NewUser = await _userManager.AddToRoleAsync(user, Role);
					return RedirectToAction("Login");
				}
				else
				{
					foreach (var error in NewUser.Errors)
					{
						ModelState.AddModelError("", error.Description);
					}
				}
				return View(model);
			}
				catch
			{
				return BadRequest("Error at signup");
			}
			
		}
		#endregion

		//================= SignOut Region ===============
		#region SignOut
		public async Task<IActionResult> LogOut()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Login", "Auth");
		}

		#endregion

		//================= Forget Password Region ===============
		#region ForgetPassword
		public IActionResult Forgetpassword()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> SendLinkResetpassword(ForgetPasswordViewModel model)
		{
			var user = await _userManager.FindByEmailAsync(model.Email);
			if (user is not null)
			{ 
            if (ModelState.IsValid)
			{

				var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var Resetpassword = Url.Action("ResetPassword", "Auth", new { email = model.Email ,token},Request.Scheme);
				var email = new Email
				{
					Subject = "Reset Password",
					To = model.Email,
					Body = $"Please click on the link to reset your password\n{Resetpassword}"
				};
                 EmailSetting.SendEmail(email);
				return RedirectToAction("CheckEmail");
            }
            }
            return View(model); 
        }
		public IActionResult CheckEmail()
        {
            return View();
        }
		[HttpGet]
		public IActionResult ResetPassword(string email, string token)
		{
			return View();
		}
		#endregion



	}
}
