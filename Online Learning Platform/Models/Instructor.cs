using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Learning_Platform.Models
{
    
    public class Instructor : UserBase
    {
        public string ImageUrl { get; set; }
        //Navigation Property
        public ICollection<Course> Courses { get; set; }

    }
}
