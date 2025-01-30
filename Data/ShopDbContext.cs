using CqrsUsingMediatRApi.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace CqrsUsingMediatRApi.Data
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("ShopDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.Description).IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.Price).IsRequired();

            modelBuilder.Entity<Product>().HasData(new List<Product>()
            {
                new Product()
                {
                    Id = Guid.Parse("124f56da-64ab-413a-8239-53eb80778f6d"),
                    Name = "Product 1",
                    Description = "Product 1",
                    Price = 100
                },
                new Product()
                {
                    Id = Guid.Parse("224f56da-64ab-413a-8239-53eb80778f6d"),
                    Name = "Product 2",
                    Description = "Product 2",
                    Price = 200
                },
                new Product()
                {
                    Id = Guid.Parse("324f56da-64ab-413a-8239-53eb80778f6d"),
                    Name = "Product 3",
                    Description = "Product 3",
                    Price = 300
                }
            });
        }
    }
}
