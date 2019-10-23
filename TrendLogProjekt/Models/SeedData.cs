﻿using System;
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
                if (context.topAuthors.Any()) {
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
                        Name = "Hans Kristiansen",
                        Occupation = "Web Dev",
                        Money = 100,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "Copenhagen",
                        Status = "Active"

                    },
                    new TopAuthor {
                        Name = "Peter Thomsen",
                        Occupation = "Web Dev",
                        Money = 150,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "Berlin",
                        Status = "Active"

                    },
                    new TopAuthor {
                        Name = "Mogens Mogensen",
                        Occupation = "Web Dev",
                        Money = 34,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "Aalborg",
                        Status = "Pending"

                    },
                    new TopAuthor {
                        Name = "Mads Madsen",
                        Occupation = "Web Dev",
                        Money = 166,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "Madrid",
                        Status = "Active"

                    },
                    new TopAuthor {
                        Name = "Kurt Knudsen",
                        Occupation = "Web Dev",
                        Money = 178,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "Aarhus",
                        Status = "Active"

                    },
                    new TopAuthor {
                        Name = "Kirsten Lysgaard",
                        Occupation = "Web Dev",
                        Money = 342,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "Paris",
                        Status = "Active"

                    },
                    new TopAuthor {
                        Name = "Peter Petersen",
                        Occupation = "Web Dev",
                        Money = 233,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "Rom",
                        Status = "Active"

                    },
                    new TopAuthor {
                        Name = "Kristian Kjeldsen",
                        Occupation = "Web Dev",
                        Money = 100,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "Odense",
                        Status = "Active"

                    },
                    new TopAuthor {
                        Name = "Søren Sørensen",
                        Occupation = "Web Dev",
                        Money = 623,
                        ImageLocation = "assets/images/avatars/4.jpg",
                        Location = "London",
                        Status = "Active"

                    },
                    new TopAuthor {
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
