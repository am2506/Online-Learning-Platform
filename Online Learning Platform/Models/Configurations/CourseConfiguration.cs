using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Online_Learning_Platform.Models.Configurations
{
	public class CourseConfiguration : IEntityTypeConfiguration<Course>
	{
		public void Configure(EntityTypeBuilder<Course> builder)
		{
			builder.HasOne(C => C.Instructor)
				.WithMany(I => I.Courses)
				.HasForeignKey(C => C.InstructorId);

			builder.HasMany(C => C.Enrollments)
			  .WithOne(E => E.Course)
			  .HasForeignKey(E => E.CourseId);

			builder.HasOne(Cg => Cg.Category)
				.WithMany(c => c.Courses)
				.HasForeignKey(c => c.CategoryId);

			builder.HasMany(C => C.Lessons)
				.WithOne(L => L.Course)
				.HasForeignKey(L => L.CourseId);


		}
	}
}
