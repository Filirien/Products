using Microsoft.EntityFrameworkCore;
using Products.Data.Models;

namespace Products.Data
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
        : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Product>()
                .HasOne(p => p.ProductType)
                .WithMany(pt => pt.Products)
                .HasForeignKey(p => p.TypeId);

            builder.Entity<ProductType>().HasData(
               new ProductType { Id = 1, Description = "Shampoos" },
               new ProductType { Id = 2, Description = "Fruits" },
               new ProductType
               {
                   Id = 3,
                   Description = "Vegetables"
               });

            builder.Entity<Product>().HasData(
                new Product { Id = 1, Description = "Gernier", UserId = 3, TypeId = 1 },
                new Product { Id = 2, Description = "Head & Shoulders", UserId = 3, TypeId = 1 },
                new Product { Id = 3, Description = "Leganza", UserId = 3, TypeId = 1 },
                new Product { Id = 4, Description = "Loreal", UserId = 3, TypeId = 1 },
                new Product { Id = 5, Description = "Shauma", UserId = 2, TypeId = 1 },
                new Product { Id = 6, Description = "Shauma Nature", UserId = 2, TypeId = 1 },
                new Product { Id = 7, Description = "Wash & Go", UserId = 1, TypeId = 1 },
                new Product { Id = 8, Description = "ARGAN", UserId = 1, TypeId = 1 },
                new Product { Id = 9, Description = "Banana", UserId = 3, TypeId = 2 },
                new Product { Id = 10, Description = "Avocado", UserId = 3, TypeId = 2 },
                new Product { Id = 11, Description = "Cherry", UserId = 2, TypeId = 2 },
                new Product { Id = 12, Description = "Grapefruit", UserId = 2, TypeId = 2 },
                new Product { Id = 13, Description = "Grape", UserId = 2, TypeId = 2 },
                new Product { Id = 14, Description = "Lemon", UserId = 2, TypeId = 2 },
                new Product { Id = 15, Description = "Mango", UserId = 1, TypeId = 2 },
                new Product { Id = 16, Description = "Mandarin", UserId = 1, TypeId = 2 },
                new Product { Id = 17, Description = "Carrot", UserId = 3, TypeId = 3 },
                new Product { Id = 18, Description = "Cucumber", UserId = 3, TypeId = 3 },
                new Product { Id = 19, Description = "Garlic", UserId = 2, TypeId = 3 },
                new Product { Id = 20, Description = "Potato", UserId = 1, TypeId = 3 },
                new Product { Id = 21, Description = "Melon", UserId = 1, TypeId = 3 },
                new Product { Id = 22, Description = "Broccoli", UserId = 1, TypeId = 3 },
                new Product { Id = 23, Description = "Asparagus", UserId = 1, TypeId = 3 },
                new Product { Id = 24, Description = "Fennel", UserId = 1, TypeId = 3 }
                );

            base.OnModelCreating(builder);
        }
    }
}
