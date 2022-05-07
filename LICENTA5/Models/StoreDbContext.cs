using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LICENTA5.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LICENTA5.Models
{
    public class StoreDbContext : IdentityDbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
   : base(options) { }
        public StoreDbContext()
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantGallery> RestaurantGallery { get; set; }


        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<RestaurantRating> Ratings { get; set; }
        public DbSet<GiftCard> GiftCards { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

        }
    }
}
