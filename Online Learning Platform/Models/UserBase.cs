using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Online_Learning_Platform.Models
{
	public class UserBase : IdentityUser<int>
	{

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        //public int Id { get; set; }  // This represents the UserId from Identity
        //public string UserName { get; set; }
        //  [DataType(DataType.EmailAddress)]
        // public string Email { get; set; }
        public string RoleName { get; set; }  // Role Name


        //[Timestamp]
        //public byte[] RowVersion { get; set; } // Concurrency token





    }

}
