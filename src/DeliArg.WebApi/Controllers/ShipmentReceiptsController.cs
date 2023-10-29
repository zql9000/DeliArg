using DeliArg.WebApi.Models;
using DeliArg.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DeliArg.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ShipmentReceiptsController 
    : BaseController<IShipmentReceiptService, ShipmentReceiptRequestDto, ShipmentReceiptResponseDto>
{
    public ShipmentReceiptsController(IShipmentReceiptService service) : base(service) {}
}
