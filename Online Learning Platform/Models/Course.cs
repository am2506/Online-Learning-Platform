namespace Online_Learning_Platform.Models
{
	public class Course
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string ? Description { get; set; }
		public string? ImageUrl { get; set; }
		public double Duration { get; set; }
		public int TotalLecture { get; set; }
		//Foreign Key
		public int CategoryId { get; set; }	
		public int InstructorId { get; set; }

		//Navigation Property
		public ICollection<Lesson> Lessons { get; set; }
		public Instructor Instructor { get; set; }
		public Category Category { get; set; }
		public ICollection<Enrollment> Enrollments { get; set; }

	}
}
