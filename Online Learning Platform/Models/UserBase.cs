using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Online_Learning_Platform.Models
{
	public class UserBase : IdentityUser<int>
	{

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RoleName { get; set; } 


       





    }

}
