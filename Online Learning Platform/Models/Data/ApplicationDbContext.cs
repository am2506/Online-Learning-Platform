using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Online_Learning_Platform.Models.Data
{
	public class ApplicationDbContext : IdentityDbContext<UserBase, IdentityRole<int>, int>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}
		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
			base.OnModelCreating(builder);
		}

		public DbSet<Course> Courses { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Lesson> Lessons { get; set; }
		public DbSet<Enrollment> Enrollments { get; set; }
	}
}
