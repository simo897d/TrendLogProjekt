using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.EntityFrameworkCore;
using TrendLogProjekt.Models;

namespace TrendLogProjekt.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {

        }
        public DbSet<BandwithReports> bandwithReports { get; set; }
        public DbSet<TopAuthor> topAuthors { get; set; }
    }
}
