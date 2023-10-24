using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DeliArg.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController
    : BaseController<IProductService, ProductRequestDto, ProductResponseDto>
{
    public ProductsController(IProductService service) : base(service) { }
}
