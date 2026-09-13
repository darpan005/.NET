using Microsoft.AspNetCore.Mvc;
using Day6.Service;
using Day6.DTOs;

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
    public async Task<IActionResult> GetProducts()
    {
        var products = await _service.GetProducts();

        return Ok(products);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] ProductDTO productDto)
    {
        var createdProduct = await _service.CreateProduct(productDto);
        return CreatedAtAction(nameof(GetProducts), createdProduct);
    }
}