namespace Online_Learning_Platform.Models
{
	public class Enrollment
	{
		
		public int CourseId { get; set; }
		public int StudentId { get; set; }
		public int Prograss { get; set; }
		public DateTime EnrollmentDate { get; set; }
		public Student Student { get; set; }
		public Course Course { get; set; }



	}
}
