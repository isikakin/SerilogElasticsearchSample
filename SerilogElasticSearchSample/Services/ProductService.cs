using SerilogElasticsearchSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerilogElasticsearchSample.Services
{
    public class ProductService : IProductService
    {
        readonly List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Xiaomi"
            },
            new Product
            {
                Id=2,
                Name = "iPhone"
            },
            new Product
            {
                Id = 3,
                Name = "Windows Phone"
            }
        };

        public Product GetProduct(int productId)
        {
            return Products.FirstOrDefault(x => x.Id == productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return Products;
        }
    }
}
