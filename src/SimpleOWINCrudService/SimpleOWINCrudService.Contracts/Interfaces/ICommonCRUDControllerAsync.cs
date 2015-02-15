
using System.Net.Http;
using System.Threading.Tasks;

namespace SimpleOWINCrudService.Contracts.Interfaces
{
    public interface ICommonCRUDControllerAsync<T>
    {
        Task<HttpResponseMessage> GetByIdAsync(long id);
        Task<HttpResponseMessage> CreateAsync(T entity);
        Task<HttpResponseMessage> UpdatAsync(T entity);
        Task<HttpResponseMessage> DeleteAsync(long id);
    }
}
