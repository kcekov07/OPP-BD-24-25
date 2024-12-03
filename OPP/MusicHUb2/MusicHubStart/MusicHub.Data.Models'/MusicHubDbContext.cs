using Microsoft.EntityFrameworkCore;
using StartUp.MusicHub.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MusicHubStart.MusicHub.Data.Models_
{
    public class MusicDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Performer> Performers { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<SongPerformer> SongPerformers { get; set; }

        public MusicDbContext() { }
        public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-5F3HQ86\\SQLEXPRESS01;Database=MusicHubDb;Trusted_Connection=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            modelBuilder.Entity<SongPerformer>()
                .HasKey(sp => new { sp.SongId, sp.PerformerId });

            modelBuilder.Entity<SongPerformer>()
                .HasOne(sp => sp.Song)
                .WithMany(s => s.SongPerformers)
                .HasForeignKey(sp => sp.SongId);

            modelBuilder.Entity<SongPerformer>()
                .HasOne(sp => sp.Performer)
                .WithMany(p => p.PerformerSongs)
                .HasForeignKey(sp => sp.PerformerId);


            modelBuilder.Entity<Song>()
                .HasOne(s => s.Writer)
                .WithMany(w => w.Songs)
                .HasForeignKey(s => s.WriterId);


            modelBuilder.Entity<Song>()
                .HasOne(s => s.Album)
                .WithMany(a => a.Songs)
                .HasForeignKey(s => s.AlbumId);


            modelBuilder.Entity<Album>()
               .HasOne(a => a.Producer)
               .WithMany(p => p.Albums)
               .HasForeignKey(a => a.ProducerId);
        }

    }
}
