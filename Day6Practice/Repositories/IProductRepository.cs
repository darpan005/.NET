using Day6.Models;

namespace Day6.Repositories;

public interface IProductRepository
{
    Task<List<Product>> GetProducts();
    Task<Product> CreateProduct(Product product);
}