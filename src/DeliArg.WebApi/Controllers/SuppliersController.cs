using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DeliArg.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SuppliersController
    : BaseController<ISupplierService, SupplierRequestDto, SupplierResponseDto>
{
    public SuppliersController(ISupplierService service) : base(service) { }
}
