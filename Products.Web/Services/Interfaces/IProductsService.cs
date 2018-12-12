using Products.Data.Models;
using System.Collections.Generic;

namespace Products.Web.Services.Interfaces
{
    public interface IProductsService
    {
        List<Product> GetProductsByUserId(int userId);
        List<Product> GetAllProducts();
    }
}
