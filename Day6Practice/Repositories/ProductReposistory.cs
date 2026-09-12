using Day6.Models;

namespace Day6.Repositories;

public class ProductRepository : IProductRepository
{
    public List<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product {Id=1, Name="Laptop", Price=50000},
            new Product {Id=2, Name="Mouse", Price=500},
            new Product {Id=3, Name="KeyBoard", Price=1500},
            new Product {Id=4, Name="Monitor" , Price=10000} 
        };
    }
}