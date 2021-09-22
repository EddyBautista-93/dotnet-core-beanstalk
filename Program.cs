using System.Threading;
using System.Transactions;
using System.Reflection.PortableExecutable;
using System;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace dotnet_core_beanstalk
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
            .useKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseIISIntegration()
            .UseStartup<Startup>()
            .Build();

            host.Run();
        }
    }
}
