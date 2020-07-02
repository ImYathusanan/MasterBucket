using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterBasketApi.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ProductType { get; set; }
        public string ProductBrand { get; set; }
        public int ProductBrandId { get; set; }
        public int MyProperty { get; set; }
    }
}
