using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.DAL;

public class BoatRentalContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
{
    //public DbSet<Renter> Renters => Set<Renter>();
    //public DbSet<Owner> Owners => Set<Owner>();
    public DbSet<Booking> Bookings => Set<Booking>();
    public DbSet<Boat> Boats => Set<Boat>();
    public BoatRentalContext(DbContextOptions options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        //modelBuilder.Entity<User>()
        //   .HasDiscriminator<string>("Role")
        //   .HasValue<Renter>("Renter")
        //   .HasValue<Owner>("Owner");

        //modelBuilder.Entity<User>()
        //    .ToTable("Users");

        modelBuilder.Entity<Boat>()
         .Property(b => b.HourlyPrice)
         .HasColumnType("decimal(18, 2)");

        modelBuilder.Entity<Booking>()
           .Property(b => b.TotalPrice)
           .HasColumnType("decimal(18, 2)");

        modelBuilder.Entity<Renter>()
            .HasMany(r => r.Bookings)
            .WithOne(b => b.Renter)
            .HasForeignKey(b => b.RenterId);
           //.OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Owner>()
            .HasMany(o => o.Boats)
            .WithOne(b => b.Owner)
            .HasForeignKey(b => b.OwnerId);
            //.OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Booking>()
            .HasOne(b => b.Renter)
            .WithMany(r => r.Bookings)
            .HasForeignKey(b => b.RenterId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Booking>()
            .HasOne(b => b.Boat)
            .WithMany(bo => bo.Bookings)
            .HasForeignKey(b => b.BoatId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
