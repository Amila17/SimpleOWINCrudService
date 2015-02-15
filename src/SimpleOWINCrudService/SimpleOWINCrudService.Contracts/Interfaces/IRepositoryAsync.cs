
using System.Threading.Tasks;

namespace SimpleOWINCrudService.Contracts.Interfaces
{
    public interface IRepositoryAsync<T>
    {
        bool Initialized { get; }
        Task InitializeAsync();

        Task<T> GetByIdAsync(long id);
        Task<T> CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(long id);
    }
}
