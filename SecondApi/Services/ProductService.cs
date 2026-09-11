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
            var products = _repository.GetProducts();

            return products
                    .Where(p => p.Price >= 10)
                    .ToList();
        }

    }
}
