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

            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Programming" },
                new Category { Id = 2, Name = "Mathematics" },
                new Category { Id = 3, Name = "Science" }
            );



            builder.Entity<Instructor>().HasData(
                new Instructor { Id = 1, FirstName = "Heba", LastName = "Mohammed", Email = "Heba@gmail.com",ImageUrl= "/images/teacher_1.jpg" },
                new Instructor { Id = 2, FirstName = "Shahd", LastName = "Sofy", Email = "Shahd@gmail.com", ImageUrl = "/images/teacher_4.jpg" }
            );



            builder.Entity<Course>().HasData(
                new Course
                {
                    Id = 1,
                    Title = "C# Programming",
                    Description = "Learn the basics of C# programming.",
                    ImageUrl = "/images/cSharp.png",
                    Duration = 10.5,
                    TotalLecture = 20,
                    CategoryId = 1,
                    InstructorId = 1
                },
                new Course
                {
                    Id = 2,
                    Title = "Advanced Mathematics",
                    Description = "An advanced course on calculus and linear algebra.",
                    ImageUrl = "/images/math.png",
                    Duration = 8.0,
                    TotalLecture = 15,
                    CategoryId = 2,
                    InstructorId = 2
                },
                new Course
                {
                    Id = 3,
                    Title = "Python Programming",
                    Description = "Learn the basics of Python programming.",
                    ImageUrl = "/images/python.png",
                    Duration = 10.5,
                    TotalLecture = 20,
                    CategoryId = 1,
                    InstructorId = 1
                }


            );



            builder.Entity<Lesson>().HasData(
                new Lesson { Id = 1, CourseId = 1, VideoUrl = "/videos/video.mp4" },
                new Lesson { Id = 2, CourseId = 1, VideoUrl = "/videos/video.mp4" },
                new Lesson { Id = 3, CourseId = 2, VideoUrl = "/videos/video.mp4" },
                new Lesson { Id = 4, CourseId = 2, VideoUrl = "/videos/video.mp4" },
                new Lesson { Id = 5, CourseId = 3, VideoUrl = "/videos/video.mp4" },
                new Lesson { Id = 6, CourseId = 3, VideoUrl = "/videos/video.mp4" },
                new Lesson { Id = 7, CourseId = 3, VideoUrl = "/videos/video.mp4" }


            );



            builder.Entity<Enrollment>().HasData(
                new Enrollment
                {
                    Id = 1,
                    CourseId = 1,
                    StudentId = 1,
                    Prograss = 0,
                    EnrollmentDate = new DateTime(2024, 9, 27)
                },
                new Enrollment
                {
                    Id = 2,
                    CourseId = 2,
                    StudentId = 1,
                    Prograss = 50,
                    EnrollmentDate = new DateTime(2024, 9, 27)
                }
            );

            builder.Entity<DevData>().Property(e => e.Job).HasDefaultValue("Full Stack .Net Developer");
            builder.Entity<DevData>().Property(e => e.Address).HasDefaultValue("Fayoum ,Egypt");

            builder.Entity<DevData>().HasData(
                new DevData
                {
                    Id=1,
                    Name = "Ahmed Mansour",
                    LinkedinUrl = "https://www.linkedin.com/in/a7medmansour/",
                    ImageUrl = "/images/avatar7.png",
                    College="Faculty of Computer and Information"
                },
                new DevData
                {
                    Id=2,
                    Name = "Mohamed Khaled",
                    LinkedinUrl = "#",
                    ImageUrl = "/images/avatar7.png",
                    College="Faculty of Engineering"
                },
                new DevData
                {
                    Id=3,
                    Name = "Heba Mohamed",
                    LinkedinUrl = "https://www.linkedin.com/in/heba-muhammad-64768924a/",
                    ImageUrl = "/images/images (1).jpeg",
                    College = "Faculty of Computer and Information"
                },
                new DevData
                {
                    Id=4,
                    Name = "Nisreen Nasr",
                    LinkedinUrl = "https://www.linkedin.com/in/nisreen-nasr-295079222/",
                    ImageUrl = "/images/images (1).jpeg",
                    College = "Faculty of Computer and Information"
                },
                new DevData
                {
                    Id=5,
                    Name = "Shahd Sofy",
                    LinkedinUrl = "https://www.linkedin.com/in/shahd-sofy-6573742a7/",
                    ImageUrl = "/images/images (1).jpeg",
                    College = "Faculty of Computer and Information"
                }
                );



        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<DevData> DevData { get; set; }

	}
}
