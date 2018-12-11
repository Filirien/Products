using System.Collections.Generic;

namespace Products.Data.Models
{
    public class ProductType
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
