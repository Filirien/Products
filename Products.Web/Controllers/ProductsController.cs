using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Products.Data;
using Products.Web.Services.Interfaces;
using Products.Web.ViewModels;

namespace Products.Web.Controllers
{
    [Route("api/products")]
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductsService productsService;

        public ProductsController(IProductsService productsService, ILogger<ProductsController> logger)
        {
            this.productsService = productsService;
            _logger = logger;
        }



        [HttpGet]
        public IEnumerable<ProductViewModel> UserProducts (int userId = 0)
        {
            try
            {
                _logger.LogInformation("Get products by userId method has been entered.");
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
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                throw;
            }            
        }
    }
}