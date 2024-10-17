using Online_Learning_Platform.Models.Data;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Online_Learning_Platform.ViewModels;

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

        public int? GetCourseProgress(int courseId, int studentId)
        {
            return _context.Enrollments
                .Where(e => e.CourseId == courseId && e.StudentId == studentId).
                Select(e => e.Prograss).FirstOrDefault();
        }

        public async Task<IEnumerable<CourseProgressViewModel>> GetEnrollmentsWithProgress(int studentId)
        {
            var enrollments = await(from enrollment in _context.Enrollments
                                    join course in _context.Courses
                                    on enrollment.CourseId equals course.Id
                                    where enrollment.StudentId == studentId
                                    select new CourseProgressViewModel
                                    {
                                        CourseTitle = course.Title,
                                        Progress = enrollment.Prograss,
                                        EnrollmentDate = enrollment.EnrollmentDate
                                    }).ToListAsync();
            return enrollments;
        }

        

        public  IQueryable<Course> SearchByNameAsync(string name)
        {
            return _context.Courses.Where(c => EF.Functions.Like(c.Title, $"%{name}%"));
        }
        
    }
}
