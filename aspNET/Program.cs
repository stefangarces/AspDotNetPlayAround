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
            Debug.WriteLine("Console in debug mode");
            Console.WriteLine("Console in terminal mode");

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
