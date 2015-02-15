
using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using SimpleOWINCrudService.Contracts.Interfaces;
using SimpleOWINCrudService.Contracts.Models;
using SimpleOWINCrudService.DataAccess.InMemory;
using SimpleOWINCrudService.Service;
using SimpleOWINCrudService.Web.APIs;

namespace SimpleOWINCrudService.Web.App_Start
{
    public static class DependencyInjectionConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetAssembly(typeof (CustomerController)));
            builder.RegisterType<CustomerServiceAsync>().As<ICommonCRUDServiceAsync<Customer>>();
            builder.RegisterType<CustomerRepositoryAsync>().As<IRepositoryAsync<Customer>>().SingleInstance();

            builder.RegisterWebApiFilterProvider(config);

            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}