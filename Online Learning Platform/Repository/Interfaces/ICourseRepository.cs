using System.Collections.Generic;
using System.Threading.Tasks;
using Online_Learning_Platform.Models;

namespace Online_Learning_Platform.Repository.Interfaces
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> GetAllCoursesAsync();
        Course GetCourseById (int id); 
        
    }
}
