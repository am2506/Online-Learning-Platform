namespace Online_Learning_Platform.Models
{
	public class Lesson
	{
		public int Id { get; set; }
		public int CourseId { get; set; }
		public string VideoUrl { get; set; }

		public Course Course { get; set; }
	}
}
