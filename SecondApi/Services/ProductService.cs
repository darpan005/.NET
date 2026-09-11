using SecondApi.Models;
using SecondApi.Repositories;

namespace SecondApi.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> GetProducts()
        {
            return _repository.GetProducts();
        }

    }
}