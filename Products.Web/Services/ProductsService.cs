using Microsoft.EntityFrameworkCore;
using Products.Data;
using Products.Data.Models;
using Products.Web.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Products.Web.Services
{
    public class ProductsService : IProductsService
    {

        private ProductsDbContext db;

        public ProductsService(ProductsDbContext db)
        {
            this.db = db;
        }

        public List<Product> GetProductsByUserId(int userId)
        {
            var products = this.db.Products
                .Where(p => p.UserId == userId)
                .Include(p => p.ProductType)
                .ToList();

            return products;
        }        
    }
}
