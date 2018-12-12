using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Products.Data;
using Products.Web.Services.Interfaces;
using Products.Web.ViewModels;

namespace Products.Web.Controllers
{
    [Route("api/products")]
    public class ProductsController : Controller
    {
        private readonly IProductsService productsService;

        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }


        [HttpGet]
        public IEnumerable<ProductViewModel> UserProducts (int userId = 0)
        {
            var products = productsService.GetProductsByUserId(userId);
            var result = products
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    UserId = p.UserId,
                    Description = p.Description,
                    Type = p.ProductType.Description
                })
                .ToList();

            return result;
        }

        [HttpGet("[action]")]
        public IEnumerable<ProductViewModel> AllProducts()
        {
            var products = productsService.GetAllProducts();
            var result = products
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    UserId = p.UserId,
                    Description = p.Description,
                    Type = p.ProductType.Description
                })
                .ToList();

            return result;
        }
    }
}