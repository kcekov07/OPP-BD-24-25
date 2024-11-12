using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.models
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Person>People { get; set; }
        public DbSet<Purpose> Purpose{ get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<PersonShop> PersonShop { get; set; }

        public ShopDbContext() { }
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-M71SG0B\\SQLEXPRESS;Database=ShopDB;Trusted_Connection=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasKey(x => x.EGN);
            modelBuilder.Entity<PersonShop>().HasKey(x => new {x.ShopId, x.PersonId});
           
            base.OnModelCreating(modelBuilder);
        }
    }
}
