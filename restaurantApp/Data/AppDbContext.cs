using Microsoft.EntityFrameworkCore;
using restaurantApp.Models;

namespace restaurantApp.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Soup>().HasData(
               new Soup { Id = 1, Type = "Tomato Soup", Price=5.99 },
               new Soup { Id = 2, Type = "Cheese Soup", Price = 5.99 },
               new Soup { Id = 3, Type = "Mushroom Soup", Price = 7.99 },
               new Soup { Id = 4, Type = "Duck Soup", Price = 10.00 },
               new Soup { Id = 5, Type = "Potato Soup", Price = 7.99 });

            modelBuilder.Entity<Meal>().HasData(
                 new Meal { Id = 1, Type = "Spagetti Bolognese", Price = 8.99 },
               new Meal { Id = 2, Type = "Spagetti Carbonaro", Price = 8.99 },
               new Meal { Id = 3, Type = "Spagetti Pomodoro", Price = 6.99 },
               new Meal { Id = 4, Type = "Spagetti Puttanesca", Price = 8.00 },
               new Meal { Id = 5, Type = "Spagetti Sardine", Price = 11.99 });

            modelBuilder.Entity<Desserts>().HasData(
                 new Desserts { Id = 1, Type = "Coconut Cake", Price = 5.50 },
               new Desserts { Id = 2, Type = "Coco-butter Cake", Price = 4.00 },
               new Desserts { Id = 3, Type = "Pear-creme Cake", Price = 6.99 },
               new Desserts { Id = 4, Type = "Ginger Cake", Price = 5.50 },
               new Desserts { Id = 5, Type = "Lemon cake", Price = 5.50 });

        }

        public DbSet<Soup> Soups { get; set; }

        public DbSet<Meal> Meals { get; set; }

        public DbSet<Desserts> Desserts { get; set; }
    }
}
