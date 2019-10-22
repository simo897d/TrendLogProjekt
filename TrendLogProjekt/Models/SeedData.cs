using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrendLogProjekt.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TrendLogProjekt.Models
{
    public class SeedData
    {
        public static void InitializeData(IServiceProvider serviceProvider) {
            using (var context = new DataContext(serviceProvider.GetRequiredService<DbContextOptions<DataContext>>())) {
                if (context.bandwithReports.Any() && context.topAuthors.Any()) {
                    return;
                }

                context.bandwithReports.AddRange(
                    new BandwithReports {
                        GeneratedLeads = 50,
                        ServerAllocation = 50,
                        SubmittedTickets = 10,
                        GeneratedLeads2 = 0,
                    }) ;
                context.topAuthors.AddRange(
                    new TopAuthor {

                        ID = 0,
                        Name = "Hans Kristiansen",
                        Occupation = "Web Dev",
                        Money = 100,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "Copenhagen",
                        Status = "Active",

                    });
                
                context.SaveChanges();
            }
        }   


    }
}
