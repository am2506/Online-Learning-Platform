using System.Collections.Generic;
using System.Threading.Tasks;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.ViewModels;

namespace Online_Learning_Platform.Repository.Interfaces
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> GetAllCoursesAsync();
		IQueryable<Course> SearchByNameAsync(string name);
        IQueryable<Course> CoursesOfUser(int Id);
        Task<IEnumerable<CourseProgressViewModel>> GetEnrollmentsWithProgress(int studentId);
    }
}
