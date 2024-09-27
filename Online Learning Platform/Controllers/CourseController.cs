using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.Repository.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace Online_Learning_Platform.Controllers
{
    public class CourseController : Controller
    {
        Icources icourse;
        IWebHostEnvironment _IWebHostEnvironment;
        public CourseController(Icources crs, IWebHostEnvironment iWebHostEnvironment)
        {
            icourse = crs;
            _IWebHostEnvironment = iWebHostEnvironment;
        }
        public IActionResult Index()
        {

            return View("Index",icourse.GetCourses());
        }
       
        public IActionResult Add()
        {
            ViewBag.category = icourse.GetCategories();
            return View("Add",new Course());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveAdd(Course course)
        {
            if(ModelState.IsValid)
            {
                if (course.ImageFile != null)
                {

                    Guid imageGuid = Guid.NewGuid();
                    string imageExtension = Path.GetExtension(course.ImageFile.FileName);

                    course.ImageUrl = "\\Images\\" + imageGuid + imageExtension;
                    string imageUploadPath = _IWebHostEnvironment.WebRootPath + course.ImageUrl;

                    FileStream imageStream = new FileStream(imageUploadPath, FileMode.Create);
                    course.ImageFile.CopyTo(imageStream);
                    imageStream.Dispose();
                }



                icourse.Insert(course);
                return RedirectToAction("Index");
                
                
            }

            return View("Add",course);
        }
    }
}
