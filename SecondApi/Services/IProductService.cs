using SecondApi.Models;

namespace SecondApi.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}