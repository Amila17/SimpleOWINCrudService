
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using SimpleOWINCrudService.Contracts.Interfaces;
using SimpleOWINCrudService.Contracts.Models;

namespace SimpleOWINCrudService.Web.APIs
{
    public class CustomerController : ApiController, ICommonCRUDControllerAsync<Customer>
    {
        private readonly ICommonCRUDServiceAsync<Customer> _customerService;

        public CustomerController(ICommonCRUDServiceAsync<Customer> customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<HttpResponseMessage> GetByIdAsync(long id)
        {
            var item = await _customerService.GetByIdAsync(id).ConfigureAwait(false);

            if (item == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, item);
        }

        [HttpPost]
        public async Task<HttpResponseMessage> CreateAsync(Customer entity)
        {
            var item = await _customerService.CreateAsync(entity).ConfigureAwait(false);

            return Request.CreateResponse(HttpStatusCode.OK, item);
        }

        [HttpPut]
        public async Task<HttpResponseMessage> UpdatAsync(Customer entity)
        {
            await _customerService.UpdateAsync(entity).ConfigureAwait(false);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        public async Task<HttpResponseMessage> DeleteAsync(long id)
        {
            await _customerService.DeleteAsync(id).ConfigureAwait(false);

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
