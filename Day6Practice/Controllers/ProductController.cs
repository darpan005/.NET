using Microsoft.AspNetCore.Mvc;
using Day6.Service;

namespace Day6.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _service;

    public ProductController(IProductService service)
    {
        _service = service;
    }

    //Get Products
    [HttpGet]
    public IActionResult GetProducts()
    {
        var products = _service.GetProducts();
        return Ok(products);
    }
}