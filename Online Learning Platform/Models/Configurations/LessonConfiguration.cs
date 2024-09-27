using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Online_Learning_Platform.Models.Configurations
{
	public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
	{
		public void Configure(EntityTypeBuilder<Lesson> builder)
		{
			builder.HasKey(L => new { L.Id, L.CourseId });

			builder.HasOne(l => l.Course)
			.WithMany(c => c.Lessons)
			   .HasForeignKey(l => l.CourseId);
		}
	}
}
