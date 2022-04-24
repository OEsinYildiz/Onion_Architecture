using ETicaret.Application.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _service;

    public ProductsController(IProductService service)
    {
        _service = service;
    }
    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(_service.GetAllProducts());
    }
}