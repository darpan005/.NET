using Microsoft.AspNetCore.Mvc;
using FirstApi.Models;

namespace FirstApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id=1, Name="Pen", Price=2.5},
                new Product {Id=2, Name="Pencil", Price=10.5},
                new Product { Id=3, Name="book", Price=30.0}
            };

            return Ok(products);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            product.Id = id;

            return Ok(product);

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            return Ok($"Product with id {id} has been deleted");
        }

    }
}