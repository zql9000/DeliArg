using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DeliArg.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ShipmentReceiptStatusesController 
    : BaseController<IShipmentReceiptStatusService, ShipmentReceiptStatusRequestDto, ShipmentReceiptStatusResponseDto>
{
    public ShipmentReceiptStatusesController(IShipmentReceiptStatusService service) : base(service) {}
}
