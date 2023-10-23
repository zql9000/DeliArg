using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DeliArg.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderStatusesController
    : BaseController<IOrderStatusService, OrderStatusRequestDto, OrderStatusResponseDto>
{
    public OrderStatusesController(IOrderStatusService service) : base(service) { }
}
