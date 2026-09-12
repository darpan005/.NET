using Day6.Models;

namespace Day6.Repositories;

public interface IProductRepository
{
    List<Product> GetProducts();
}