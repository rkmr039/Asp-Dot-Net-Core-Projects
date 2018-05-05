using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FirstApp
{
    public class Program
    {
        /*
         * Execution of webapp starts with main() 
         */
        public static void Main(string[] args)
        {
            /*
            * CreateDefaultBuilder() : Use Kestrel( cross-platform web server), set the ContentRootPath, etc.
            * UseStartup<Startup>() : ConfigureServices(), Configure()
            * Build() : Makes the server ready
            * Run() : Start Listing
            */
            BuildWebHost(args).Run();// run the host

        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();// build the host
    }
}