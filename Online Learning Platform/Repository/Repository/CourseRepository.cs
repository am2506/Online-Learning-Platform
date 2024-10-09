using Online_Learning_Platform.Models.Data;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Online_Learning_Platform.Repository.Repository
{
    public class CourseRepository:ICourseRepository
    {
        private readonly ApplicationDbContext _context;

        public CourseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Course>> GetAllCoursesAsync()
        {
            return await _context.Courses
                .Include(c => c.Instructor)
                .Include(c => c.Category)
                .ToListAsync();
        }
    }
}
