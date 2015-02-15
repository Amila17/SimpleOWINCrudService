
using System;
using System.Threading.Tasks;
using SimpleOWINCrudService.Contracts.Interfaces;
using SimpleOWINCrudService.Contracts.Models;

namespace SimpleOWINCrudService.Service
{
    public class CustomerServiceAsync : ICommonCRUDServiceAsync<Customer>
    {
        private readonly IRepositoryAsync<Customer> _customerRepository;

        public CustomerServiceAsync(IRepositoryAsync<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> GetByIdAsync(long id)
        {
            return await _customerRepository.GetByIdAsync(id).ConfigureAwait(false);
        }

        public async Task<Customer> CreateAsync(Customer entity)
        {
            var now = DateTime.UtcNow;
            entity.CreatedDate = now;
            entity.LastUpdatedDate = now;
            return await _customerRepository.CreateAsync(entity).ConfigureAwait(false);
        }

        public async Task UpdateAsync(Customer entity)
        {
            entity.LastUpdatedDate = DateTime.UtcNow;
            await _customerRepository.UpdateAsync(entity).ConfigureAwait(false);
        }

        public async Task DeleteAsync(long id)
        {
            await _customerRepository.DeleteAsync(id).ConfigureAwait(false);
        }
    }
}
