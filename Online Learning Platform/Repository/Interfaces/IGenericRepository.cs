using Online_Learning_Platform.Models;
using System.Linq.Expressions;

namespace Online_Learning_Platform.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetWithIncludesAsync(params Expression<Func<T, object>>[] includes);
		Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);


	}
}
