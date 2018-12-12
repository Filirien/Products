using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Web.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        
        public int UserId { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }
    }
}
