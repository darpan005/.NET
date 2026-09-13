using Day6.DTOs;

namespace Day6.Service;

public interface IProductService
{
    Task<List<ProductDTO>> GetProducts();
    Task<ProductDTO> CreateProduct(ProductDTO productdto);
}