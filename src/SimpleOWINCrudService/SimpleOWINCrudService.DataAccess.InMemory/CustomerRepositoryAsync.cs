
using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleOWINCrudService.Contracts.Interfaces;
using SimpleOWINCrudService.Contracts.Models;

namespace SimpleOWINCrudService.DataAccess.InMemory
{
    public class CustomerRepositoryAsync : IRepositoryAsync<Customer>
    {
        private IDictionary<long, Customer> _customerStore;
        public bool Initialized { get; private set; }

        public CustomerRepositoryAsync()
        {
            InitializeAsync().GetAwaiter().GetResult();
        }

        public async Task InitializeAsync()
        {
            _customerStore = new Dictionary<long, Customer>();
            Initialized = true;
        }

        public async Task<Customer> GetByIdAsync(long id)
        {
            Customer customer;
            _customerStore.TryGetValue(id, out customer);
            return customer;
        }

        public async Task<Customer> CreateAsync(Customer entity)
        {
            _customerStore.Add(entity.Id, entity);
            return entity;
        }

        public async Task UpdateAsync(Customer entity)
        {
            _customerStore.Remove(entity.Id);
            _customerStore.Add(entity.Id, entity);
        }

        public async Task DeleteAsync(long id)
        {
            _customerStore.Remove(id);
        }
    }
}
