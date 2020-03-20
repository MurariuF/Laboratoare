using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryNetCore
{
    internal class ModelContext : DbContext
    {
        public DbSet<Customer> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-1SGHRAO;  Database = EFCore2020; Trusted_Connection = True");
        //ChangeTracker.LazyLoadingEnabled = false;
 }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
            .HasMany<Order>(o => o.Orders)
            .WithOne(c => c.Customer);

            modelBuilder.Entity<Artist>()
            .HasMany<Album>(od => od.Albums);

            modelBuilder.Entity<Album>()
            .HasMany<Artist>(a => a.Artists);

        }
    }
}
