using Microsoft.AspNetCore.Identity;

namespace Online_Learning_Platform.Models
{
	public class UserBase : IdentityUser<int>
	{
		
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string? ImageUrl { get; set; }
	}
}
