using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DeliArg.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductSuppliersController
    : BaseController<IProductSupplierService, ProductSupplierRequestDto, ProductSupplierResponseDto>
{
    public ProductSuppliersController(IProductSupplierService service) : base(service) { }
}
