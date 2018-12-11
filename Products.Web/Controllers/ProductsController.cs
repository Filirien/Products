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
    [Route("api")]
    public class ProductsController : Controller
    {
        private readonly IProductsService productsService;

        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        [Route("products/userid/{id}")]
        [HttpGet]
        public IEnumerable<ProductViewModel> Index(int id)
        {
            var products = productsService.GetProductsByUserId(id);
            var result = products
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Description = p.Description,
                    Type = p.ProductType.Description
                })
                .ToList();

            return result;
        }
    }
}