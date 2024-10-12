using Microsoft.AspNetCore.Identity;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.Models.Data;
using Online_Learning_Platform.Repository.Interfaces;

namespace Online_Learning_Platform.Repository.Repository
{
    public class UserRepository : IUserRepository
    {
        
        private readonly UserManager<UserBase> _userManager;

        public UserRepository(UserManager<UserBase> userManager)
        {
           _userManager = userManager;
        }
        public async Task<UserBase> GetUserByUserName(string userName)
        {
            return _userManager.FindByNameAsync(userName).Result;
        }
    }
}
