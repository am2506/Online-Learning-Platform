using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Scripting;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.Models.Data;
using Online_Learning_Platform.Repository.Interfaces;
using Online_Learning_Platform.ViewModels;

namespace Online_Learning_Platform.Controllers
{
	public class EnrollmentController : Controller
	{
		ICourseRepository courseRepository;
		UserManager<UserBase> userManager;
		SignInManager<UserBase> signInManager;
		IEnrollmentRepository enrollmentRepository;
        public EnrollmentController(ICourseRepository courseRepository,UserManager<UserBase> userManager,SignInManager<UserBase>signInManager,IEnrollmentRepository enrollmentRepository)
        {
            this.courseRepository = courseRepository;
			this.userManager = userManager;
			this.signInManager = signInManager;
			this.enrollmentRepository = enrollmentRepository;
        }
        public async Task<IActionResult> Enroll(int Id)
		{
			Course course= await courseRepository.GetCourseById(Id);
            
            return View( course);
		}

        [Authorize]
		public IActionResult Save(int courseid)
		{
			
		    var checkin=signInManager.IsSignedIn(User);

            if (checkin)
            {
                var userid = Int16.Parse(userManager.GetUserId(User));
                if (userid != null)
                {
                    var ckeckenrollornot = enrollmentRepository.check(courseid, userid);
                    if (ckeckenrollornot)
                    {
                        ViewBag.message = 0;
                    }
                    else
                    {
                        Enrollment enrollment = new Enrollment()
                        {
                            CourseId = courseid,
                            EnrollmentDate = DateTime.Now,
                            Prograss = 0,
                            StudentId = userid
                        };
                        enrollmentRepository.Insert(enrollment);
                        enrollmentRepository.Save();
                        ViewBag.message = 1;
                    }
                }
               
            }

           


            return View();
			

			
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
