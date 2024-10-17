using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Online_Learning_Platform.Models.Configurations
{
	public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
	{
		public void Configure(EntityTypeBuilder<Enrollment> builder)
		{
			builder.HasKey(e => new { e.StudentId, e.CourseId });
			builder.Property(e => e.Prograss)
                .HasDefaultValue(0);
			builder.Property(e => e.EnrollmentDate)
				.HasDefaultValueSql("getdate()");

            builder.HasOne(e => e.Student)
			  .WithMany(s => s.Enrollments)
			  .HasForeignKey(e => e.StudentId)
			  .OnDelete(DeleteBehavior.Cascade); ;

			builder.HasOne(e => e.Course)
			  .WithMany(c => c.Enrollments)
			  .HasForeignKey(e => e.CourseId)
			  .OnDelete(DeleteBehavior.Restrict); 
		}
	}
}
