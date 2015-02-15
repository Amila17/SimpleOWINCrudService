
using System.Web.Http;

namespace SimpleOWINCrudService.Core.Configurations
{
    public static class MediaFormatterConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.Remove(config.Formatters.XmlFormatter);

        }
    }
}