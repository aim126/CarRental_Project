using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarRentalProject.Models;

namespace CarRentalProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public
    ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {

                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    }
                );



        }
        public DbSet<CarRentalProject.Models.RentalOrder> RentalOrder { get; set; }
        public DbSet<CarRentalProject.Models.Reservation> Reservation { get; set; }


    }

}