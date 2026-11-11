using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Contexts
{
    internal class AppDbContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EventHubDB;Trusted_Connection=True;TrustServerCertificate=true");

        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configurations.AttendeeConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.BadgeConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.EventConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.RegisterConfiguration());
        }

        public DbSet<Models.Profile> Profiles { get; set; }
        public DbSet<Models.Organizer> Organizers { get; set; }
        
    }
}
