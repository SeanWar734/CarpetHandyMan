using CarpetHandyMan.Core.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetHandyMan.infrastructure
{
    public class CarpetContext : DbContext
    {
        public CarpetContext(DbContextOptions options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Lazy Load
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(("Server =./; Integrated Security = False; Database = CarpetHandyManDB"), b => b.MigrationsAssembly("CarpetHandyMan.Api"));
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Retailer> Retailers { get; set; }
        public DbSet<Installer> Installers { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Staircase> Staircases { get; set; }
        public DbSet<Stair> Stairs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Closet> Closets { get; set; }
        public DbSet<Carpet> Carpet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                        .HasOne<Building>()
                        .WithOne();

            modelBuilder.Entity<Staircase>()
                        .HasOne<Building>()
                        .WithMany()
                        .HasForeignKey(sc => sc.BuildingId);

            modelBuilder.Entity<Room>()
                        .HasOne<Building>()
                        .WithMany()
                        .HasForeignKey(r => r.BuildingId);

            modelBuilder.Entity<Stair>()
                        .HasOne<Staircase>()
                        .WithMany()
                        .HasForeignKey(s => s.StaircaseId)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Closet>()
                        .HasOne<Room>()
                        .WithMany()
                        .HasForeignKey(c => c.RoomId);

            modelBuilder.Entity<Room>()
                        .HasOne<Building>()
                        .WithMany()
                        .HasForeignKey(r => r.BuildingId);

            modelBuilder.Entity<Customer>()
                        .HasOne<Order>()
                        .WithOne();

            modelBuilder.Entity<Retailer>()
                        .HasOne<Order>()
                        .WithOne()
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Installer>()
                        .HasOne<Order>()
                        .WithOne();

            modelBuilder.Entity<Order>()
                        .HasMany<Carpet>()
                        .WithOne();

            modelBuilder.Entity<Room>()
                        .HasOne<Carpet>()
                        .WithMany()
                        .HasForeignKey(r => r.CarpetId);

            modelBuilder.Entity<Stair>()
                        .HasOne<Carpet>()
                        .WithMany()
                        .HasForeignKey(s => s.CarpetId);

            modelBuilder.Entity<Staircase>()
                        .HasOne<Carpet>()
                        .WithMany()
                        .HasForeignKey(sc => sc.CarpetId);
        }
    }
}