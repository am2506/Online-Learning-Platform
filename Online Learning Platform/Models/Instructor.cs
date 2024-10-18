using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Learning_Platform.Models
{
    
    public class Instructor : UserBase
    {
		//Navigation Property
		public ICollection<Course> Courses { get; set; }

    }
}
