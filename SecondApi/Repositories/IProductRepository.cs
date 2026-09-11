using SecondApi.Models;

namespace SecondApi.Repositories
{
    public interface IProductRepository
{
    List<Product> GetProducts();
}
}