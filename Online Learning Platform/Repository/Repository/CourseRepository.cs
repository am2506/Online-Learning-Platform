using Online_Learning_Platform.Models.Data;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Online_Learning_Platform.Repository.Repository
{

    public class CourseRepository : ICourseRepository

    {
        private readonly ApplicationDbContext _context;

        public CourseRepository(ApplicationDbContext context)
        {
            _context = context;
        }


		public IQueryable<Course> CoursesOfUser(int Id)
		{
			var UserCourse = _context.Enrollments
				.Include(C => C.Course)
				.Include(S => S.Student)
				.Where(e => e.StudentId == Id)
				.Select(e => e.Course);
            return UserCourse;
		}


        public async Task<IEnumerable<Course>> GetAllCoursesAsync()

        {
            return await _context.Courses
                .Include(c => c.Instructor)
                .Include(c => c.Category)
                .ToListAsync();
        }


		public Course GetCourseById(int id)
		{
            return _context.Courses.Include(u => u.Lessons).Include(x => x.Category).Include(d => d.Instructor).FirstOrDefault(c => c.Id == id);
		}

        public IQueryable<Course> SearchByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }

        
        //public IQueryable<Course> SearchByNameAsync(string name)
        //{

        //    return _context.Courses
        //        .Where(c => c.Title.Contains(name, StringComparison.OrdinalIgnoreCase))
        //        .AsQueryable();
        //}

}


