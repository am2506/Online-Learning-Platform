using Online_Learning_Platform.Models;

namespace Online_Learning_Platform.ViewModels
{
	public class CourseIndexViewModel
	{
		public IEnumerable<Course> Courses { get; set; }
		public IEnumerable<Category> Categories { get; set; }
	}
}
