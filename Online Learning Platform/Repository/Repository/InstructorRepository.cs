using Microsoft.EntityFrameworkCore;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.Models.Data;
using Online_Learning_Platform.Repository.Interfaces;

namespace Online_Learning_Platform.Repository.Repository
{
    public class InstructorRepository : IInstructorRepository
    {
        ApplicationDbContext context;
        public InstructorRepository(ApplicationDbContext _context)
        {
            context = _context;
        }
        public Instructor GetById(int id)
        {
            return context.Instructors.Include(c => c.Courses).FirstOrDefault(e => e.Id == id);
        }
    }
}
