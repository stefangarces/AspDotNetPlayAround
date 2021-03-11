using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace aspNET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Debug.WriteLine("Test test test");
            Console.WriteLine("Test2 test2 test2");

            IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args);
            hostBuilder.ConfigureWebHostDefaults(WebHostBuilder =>
            {
                WebHostBuilder.UseStartup<Startup>();
            });
            IHost webHost = hostBuilder.Build();
            webHost.Run();
        }
    }
}
