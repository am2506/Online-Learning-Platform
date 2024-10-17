using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
            return await _userManager.FindByNameAsync(userName);
        }

        public async Task<IdentityResult> UpdateUser(UserBase user)
        {
            return await _userManager.UpdateAsync(user);
        }
    }
}
