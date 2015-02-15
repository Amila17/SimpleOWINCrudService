
using System.Web.Http;

namespace SimpleOWINCrudService.Core.Configurations
{
    public static class WebApiRoutingConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new {id = RouteParameter.Optional});
        }
    }
}