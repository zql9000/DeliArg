using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DeliArg.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WarehousesController
    : BaseController<IWarehouseService, WarehouseRequestDto, WarehouseResponseDto>
{
    public WarehousesController(IWarehouseService service) : base(service) { }
}
