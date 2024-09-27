using Microsoft.EntityFrameworkCore.Infrastructure;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.Models.Data;
using Online_Learning_Platform.Repository.Interfaces;

namespace Online_Learning_Platform.Repository
{
    public class CourseRepository:Icources
    {
        ApplicationDbContext _context;
        public CourseRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();

        }

        public List<Course> GetCourses()
        {
            return _context.Courses.ToList();

        }



        public void Insert(Course course)
        {
           _context.Courses.Add(course);
            _context.SaveChanges();
        }
    }
}
