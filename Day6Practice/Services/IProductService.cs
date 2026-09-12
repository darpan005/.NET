using Day6.DTOs;

namespace Day6.Service;

public interface IProductService
{
    List<ProductDTO> GetProducts();
}