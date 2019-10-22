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
                    }
            ) ;
                context.topAuthors.AddRange(
                    new TopAuthor {

                        ID = 0,
                        Name = "Hans Kristiansen",
                        Occupation = "Web Dev",
                        Money = 100,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "Copenhagen",
                        Status = "Active"

                    },
                    new TopAuthor {

                        ID = 1,
                        Name = "Peter Thomsen",
                        Occupation = "Web Dev",
                        Money = 150,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "Berlin",
                        Status = "Active"

                    },
                    new TopAuthor {

                        ID = 2,
                        Name = "Mogens Mogensen",
                        Occupation = "Web Dev",
                        Money = 34,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "Aalborg",
                        Status = "Pending"

                    },
                    new TopAuthor {

                        ID = 3,
                        Name = "Mads Madsen",
                        Occupation = "Web Dev",
                        Money = 166,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "Madrid",
                        Status = "Active"

                    },
                    new TopAuthor {

                        ID = 4,
                        Name = "Kurt Knudsen",
                        Occupation = "Web Dev",
                        Money = 178,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "Aarhus",
                        Status = "Active"

                    },
                    new TopAuthor {

                        ID = 5,
                        Name = "Kirsten Lysgaard",
                        Occupation = "Web Dev",
                        Money = 342,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "Paris",
                        Status = "Active"

                    },
                    new TopAuthor {

                        ID = 6,
                        Name = "Peter Petersen",
                        Occupation = "Web Dev",
                        Money = 233,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "Rom",
                        Status = "Active"

                    },
                    new TopAuthor {

                        ID = 7,
                        Name = "Kristian Kjeldsen",
                        Occupation = "Web Dev",
                        Money = 100,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "Odense",
                        Status = "Active"

                    },
                    new TopAuthor {

                        ID = 8,
                        Name = "Søren Sørensen",
                        Occupation = "Web Dev",
                        Money = 623,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "London",
                        Status = "Active"

                    },
                    new TopAuthor {

                        ID = 9,
                        Name = "Thomas Thomasen",
                        Occupation = "Web Dev",
                        Money = 243,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "Hamborg",
                        Status = "Active"

                    }); 
                
                context.SaveChanges();
            }
        }   


    }
}
