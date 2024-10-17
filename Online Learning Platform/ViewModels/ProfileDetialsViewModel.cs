namespace Online_Learning_Platform.ViewModels
{
	public class ProfileDetialsViewModel
	{
		public int Id { get; set; }
        public string ?UserName { get; set; }
        public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string ?PhoneNumber { get; set; }
        public string? ImageUrl { get; set; }  // URL of the profile image
		public IFormFile ? ProfileImage { get; set; } // Image file to be uploaded
    }
}
