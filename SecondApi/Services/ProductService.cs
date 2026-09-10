using SecondApi.Models;

namespace SecondApi.Services
{
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product {Id = 1, Name = "Product 1", Price = 10.99},
                new Product {Id = 2, Name = "Product 2", Price = 19.99},
                new Product {Id = 3, Name = "Product 3", Price = 5.99}

            };

            return products;
        }
    }
}