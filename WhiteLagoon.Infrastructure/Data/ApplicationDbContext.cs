using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WhiteLagoon.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WhiteLagoon.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {   
        }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);
           modelBuilder.Entity<Villa>().HasData(
               new Villa
               { 
                   Id = 1,
                   Name = "Royal Villa",
                   Description = "NA",
                   ImageUrl="",
                   Occupancy=2,
                   Price=10000,
                   Sqft=2               
               },
               new Villa
                {
                    Id = 2,
                    Name = "Taj Villa",
                    Description = "NA",
                    ImageUrl = "",
                    Occupancy = 2,
                    Price = 10000,
                    Sqft = 2
                }
               );
           modelBuilder.Entity<VillaNumber>().HasData(
                new VillaNumber
                {
                    Villa_Number = 100,
                    VillaId = 1,
                },
                new VillaNumber
                {
                    Villa_Number = 104,
                    VillaId = 2
                }
                );
           modelBuilder.Entity<Amenity>().HasData(
               new Amenity
               {
                    Id=1,
                    VillaId=1,
                    Name="Private Pool"
               },
                new Amenity
                {
                    Id = 2,
                    VillaId = 2,
                    Name = "Microwave"
                }
                );
        }
    }
}
