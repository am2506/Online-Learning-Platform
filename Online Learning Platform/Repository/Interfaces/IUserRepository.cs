using Online_Learning_Platform.Models;

namespace Online_Learning_Platform.Repository.Interfaces
{
    public interface IUserRepository 
    {
        Task<UserBase> GetUserByUserName(string userName);
    }
}
