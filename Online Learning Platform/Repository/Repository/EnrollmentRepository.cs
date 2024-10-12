using Online_Learning_Platform.Models;
using Online_Learning_Platform.Models.Data;
using Online_Learning_Platform.Repository.Interfaces;

namespace Online_Learning_Platform.Repository.Repository
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly ApplicationDbContext _context;

        public EnrollmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Insert(Enrollment enrollment)
        {
            _context.Enrollments.Add(enrollment);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool check(int crsid,int userid)
        {
           return  _context.Enrollments.Any(x => x.CourseId == crsid && x.StudentId == userid);
        }
    }
}
