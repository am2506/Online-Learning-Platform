using System.ComponentModel.DataAnnotations;

namespace Online_Learning_Platform.ViewModels
{
    public class AddUserViewModel
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string RoleName { get; set; }  // Role Name
        
    }
}
