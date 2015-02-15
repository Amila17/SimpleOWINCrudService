
using System.Web.Http;
using Owin;
using SimpleOWINCrudService.Web.App_Start;

namespace SimpleOWINCrudService.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();

            WebApiRoutingConfig.Register(config);
            MediaFormatterConfig.Register(config);
            DependencyInjectionConfig.Register(config);

            appBuilder.UseWebApi(config);
        }
    }
}