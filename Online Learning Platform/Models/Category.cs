namespace Online_Learning_Platform.Models
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }

		//Navigation Property
		public ICollection<Course> Courses { get; set; }
	}
}
