using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspNET.Models;

namespace aspNET.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options)
        {
            
        }

        public DbSet <Events> Eventss { get; set; }
        public DbSet <Attendee> Attendees { get; set; }
        public DbSet <Organizer> Organizers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilderz)
        {
            modelBuilderz.Entity<Events>().ToTable("Events");
            modelBuilderz.Entity<Attendee>().ToTable("Attendee");
            modelBuilderz.Entity<Organizer>().ToTable("Organizer");
        }
    }
}
