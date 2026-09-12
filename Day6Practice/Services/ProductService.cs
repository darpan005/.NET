using Day6.DTOs;
using Day6.Repositories;
using Day6.Service;

namespace Day6.Repositories;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public List<ProductDTO> GetProducts()
    {
        var allProducts = _repository.GetProducts();

        return allProducts
                .Where(p => p.Price >= 1000)
                .Select(p => new ProductDTO
                {
                    Name = p.Name,
                    Price = p.Price
                })
                .ToList();
    
    }
}