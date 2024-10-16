using FluentAssertions.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Online_Learning_Platform.ModelBL;
using Online_Learning_Platform.Models.Configurations;
using System.Reflection.Emit;

namespace Online_Learning_Platform.Models.Data
{
	public class ApplicationDbContext : IdentityDbContext<UserBase, IdentityRole<int>, int>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
    

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Apply all entity configurations
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            // Custom configurations
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new LessonConfiguration());
            builder.ApplyConfiguration(new EnrollmentConfiguration());
            builder.ApplyConfiguration(new CourseConfiguration());
         
            // Seed roles (for example, Admin, Instructor)
            builder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int> { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole<int> { Id = 2, Name = "Instructor", NormalizedName = "INSTRUCTOR" },
                new IdentityRole<int> { Id = 3, Name = "Student", NormalizedName = "STUDENT" }
            );

            #region Draft
            //// Seed instructors as Identity users
            //var hasher = new PasswordHasher<UserBase>();
            //var Users = new List<UserBase>
            //{
            //    new UserBase
            //    {
            //        Id = 1,
            //        UserName = "instructor1",

            //        Email = "instructor1@example.com",
            //                            RoleName="Instructor",


            //        PasswordHash = hasher.HashPassword(null, "Password123!")
            //    },
            //    new UserBase
            //    {
            //        Id = 2,
            //        UserName = "instructor2",

            //        Email = "instructor2@example.com",
            //                            RoleName="Instructor",


            //        PasswordHash = hasher.HashPassword(null, "Password123!")
            //    },
            //      new UserBase
            //    {
            //        Id = 4,
            //        UserName = "Student1",

            //        Email = "Student1@example.com",
            //                            RoleName="Student",


            //        PasswordHash = hasher.HashPassword(null, "Password123!")
            //    },  new UserBase
            //    {
            //        Id = 5,
            //        UserName = "Student2",
            //        Email = "Student2@example.com",
            //                            RoleName="Student",


            //        PasswordHash = hasher.HashPassword(null, "Password123!")
            //    },  new UserBase
            //    {
            //        Id = 6,
            //        UserName = "Student3",
            //        Email = "Student3@example.com",
            //                            RoleName="Student",


            //        PasswordHash = hasher.HashPassword(null, "Password123!")
            //    },
            //    new UserBase
            //    {
            //        Id = 3,
            //        UserName = "instructor3",
            //        Email = "instructor3@example.com",
            //        RoleName="Instructor",

            //        PasswordHash = hasher.HashPassword(null, "Password123!")
            //    }
            //};

            //builder.Entity<UserBase>().HasData(Users); 
            #endregion



            // Seed categories (for example)
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Development" },
                new Category { Id = 2, Name = "Design" }
            );

            // Seed courses, linking to the instructor Ids
            //builder.Entity<Course>().HasData(
            //    new Course { Id = 1, Title = "ASP.NET Core", Description = "Learn ASP.NET Core", Duration = 10, TotalLecture = 20, CategoryId = 1, InstructorId = 1 },
            //    new Course { Id = 2, Title = "Entity Framework", Description = "Learn EF Core", Duration = 8, TotalLecture = 16, CategoryId = 1, InstructorId = 2 },
            //    new Course { Id = 3, Title = "JavaScript Basics", Description = "Learn JavaScript", Duration = 6, TotalLecture = 12, CategoryId = 1, InstructorId = 3 }
            //);
            //builder.Entity<UserBase>()
            //    .Property(u => u.RowVersion)
            //    .IsRowVersion(); // Mark as concurrency token

        }


       

        public DbSet<Course> Courses { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Lesson> Lessons { get; set; }
		public DbSet<Enrollment> Enrollments { get; set; }
		//public DbSet<Student> Students { get; set; }
		//public DbSet<Instructor> Instructors { get; set; }
        //public DbSet<UserBase> userBases { get; set; }

	}
}
