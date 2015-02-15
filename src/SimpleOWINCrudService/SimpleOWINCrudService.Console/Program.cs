
using System.Configuration;
using Topshelf;

namespace SimpleOWINCrudService.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = ConfigurationManager.AppSettings["HostAddress"];

            HostFactory.Run(x =>
            {
                x.Service<ConsoleHost>(s =>
                {
                    s.ConstructUsing(name => new ConsoleHost(address));
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();

                x.SetServiceName("SimpleOWINCrudService");
                x.SetDisplayName("Simple Owin Crud Service with Web Api 2.2");
                x.SetDescription("Simple Owin Crud Service hosting a Web Api 2.2 service.");
            });
        }
    }
}
