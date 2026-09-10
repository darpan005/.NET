using Microsoft.AspNetCore.Mvc;
using SecondApi.Services;

namespace SecondApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _service;

        public ProductController(ProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _service.GetProducts();

            return Ok(products);
        }
    }
}