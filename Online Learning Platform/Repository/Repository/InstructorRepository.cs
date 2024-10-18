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
		public async Task<Instructor> GetById(int id)
		{
			return await context.Instructors
				.Include(c => c.Courses)
				.FirstOrDefaultAsync(e => e.Id == id);
		}
	}
}
