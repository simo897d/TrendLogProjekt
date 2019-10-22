using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TrendLogProjekt.Data;
using TrendLogProjekt.Models;

namespace TrendLogProjekt
{
    public class Program
    {
        public static void Main(string[] args) {
            var host = CreateWebHostBuilder(args).Build();

            using(var scope = host.Services.CreateScope()) {
                var services = scope.ServiceProvider;
                try {
                    var context = services.GetRequiredService<DataContext>();
                    context.Database.Migrate();
                    SeedData.InitializeData(services);
                }
                catch(Exception ex) {
                    throw ex;
                }
            }
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
