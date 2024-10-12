using Microsoft.EntityFrameworkCore;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.Models.Data;
using Online_Learning_Platform.Repository.Interfaces;

namespace Online_Learning_Platform.Repository.Repository
{
    public class GenricsRepository<T> : IGenericsRepository<T> where T : BaseEntity
    {
        private protected readonly ApplicationDbContext _dbContext;

        public GenricsRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public Task<T> GetByID(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
