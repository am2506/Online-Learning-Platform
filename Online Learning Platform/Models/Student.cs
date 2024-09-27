using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Learning_Platform.Models
{
	public class Student : UserBase
	{
		public ICollection<Enrollment> Enrollments { get; set; }
	}
}
