using GeekShopping.ProductAPI.Data.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Name2",
                Price = new decimal(29.9),
                Description = "Description2",
                ImageUrl = "",
                CategoryName = "Category",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Name3",
                Price = new decimal(29.9),
                Description = "Description3",
                ImageUrl = "",
                CategoryName = "Category",
            });
        }
    }
}
