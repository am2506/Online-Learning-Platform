using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Online_Learning_Platform.Models.Configurations
{
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasMany(c => c.Courses)
				.WithOne(cg => cg.Category)
				.HasForeignKey(c => c.CategoryId);
		}
	}
}
