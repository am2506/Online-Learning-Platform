using Online_Learning_Platform.Models;

namespace Online_Learning_Platform.Repository.Interfaces
{
    public interface IInstructorRepository
    {
        Task<Instructor> GetById (int id);
    }
}
