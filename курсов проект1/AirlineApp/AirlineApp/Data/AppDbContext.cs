using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Flight> Flights { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5F3HQ86\\SQLEXPRESS01;Database=AirlineDB;Trusted_Connection=True;Encrypt=False;");
        }
    }
}
