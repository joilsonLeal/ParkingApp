using Data.Context.Mapping;
using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    public class ParkingAppContext : DbContext
    {
        public ParkingAppContext(DbContextOptions<ParkingAppContext> options) : base(options) { }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Parking> Parkings { get; set; }
        public DbSet<Spot> Spots { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProfileMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new CountryMap());
            modelBuilder.ApplyConfiguration(new ParkingMap());
            modelBuilder.ApplyConfiguration(new SpotMap());
        }
    }
}
