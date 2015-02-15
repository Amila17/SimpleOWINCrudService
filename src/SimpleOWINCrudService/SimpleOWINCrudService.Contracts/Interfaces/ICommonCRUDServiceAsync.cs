
using System.Threading.Tasks;

namespace SimpleOWINCrudService.Contracts.Interfaces
{
    public interface ICommonCRUDServiceAsync<T>
    {
        Task<T> GetByIdAsync(long id);
        Task<T> CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(long id);
    }
}
