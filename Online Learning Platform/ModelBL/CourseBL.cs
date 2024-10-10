using Online_Learning_Platform.Models;
using Online_Learning_Platform.Models.Data;
using System.Linq; // Make sure to include this for LINQ operations

namespace Online_Learning_Platform.ModelBL
{
    public class CourseBL
    {
        private readonly ApplicationDbContext _context; 

        public CourseBL()
        {
          
        }

        public List<Course> GetAll()
        {
            return _context.Courses.ToList(); 
        }

        public Course GetById(int id)
        {
            var res = _context.Courses.SingleOrDefault(x => x.Id == id); 
            return res;
        }
    }
}
