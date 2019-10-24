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
        public DbSet<BandwithReports> bandwithReports { get; set; }
        public DbSet<TopAuthor> topAuthors { get; set; }
        public DbSet<ChannelRootobject> channels { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder) {
        //    modelBuilder.Entity<Channel>().HasKey(c => new { c.channel_id,  });
        //}
    }
}
