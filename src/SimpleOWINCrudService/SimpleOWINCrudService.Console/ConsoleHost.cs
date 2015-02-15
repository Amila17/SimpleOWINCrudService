
using System;
using Microsoft.Owin.Hosting;
using SimpleOWINCrudService.Core;

namespace SimpleOWINCrudService.Console
{
    public class ConsoleHost
    {
        private readonly string _address;
        private IDisposable _instance;
        public ConsoleHost(string address)
        {
            _address = address;
        }

        public void Start()
        {
            try
            {
                _instance = WebApp.Start<Startup>(_address);
            }
            catch (Exception ex)
            {
                
                throw;
            }
            
        }

        public void Stop()
        {
            try
            {
                _instance.Dispose();
                _instance = null;
            }
            catch (Exception)
            {
                _instance = null;
            }

        }
    }
}
