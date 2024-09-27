namespace Online_Learning_Platform.Models
{
	public class Lesson : BaseEntity
	{
		
		public int CourseId { get; set; }
		public string VideoUrl { get; set; }

		public Course Course { get; set; }
	}
}
