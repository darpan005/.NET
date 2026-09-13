using Day6.DTOs;
using Day6.Repositories;
using Day6.Service;
using Day6.Models;

namespace Day6.Service;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ProductDTO>> GetProducts()
    {
        var products = await _repository.GetProducts();

        return products.Where(p => p.Price >= 1000).Select(p => new ProductDTO
        {
            Name = p.Name,
            Price = p.Price
        }).ToList();
    }

    public async Task<ProductDTO> CreateProduct(ProductDTO productdto)
    {
        var product = new Product
        {
            Name = productdto.Name,
            Price = productdto.Price
        };

        var createProduct = await _repository.CreateProduct(product);

        return new ProductDTO
        {
            Name = createProduct.Name,
            Price = createProduct.Price
        };
    }

}