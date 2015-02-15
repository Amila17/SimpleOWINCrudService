
using System.Web.Http;

namespace SimpleOWINCrudService.Web.App_Start
{
    public static class MediaFormatterConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.Remove(config.Formatters.XmlFormatter);

        }
    }
}