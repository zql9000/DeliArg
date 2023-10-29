using DeliArg.WebApi.Models;
using DeliArg.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DeliArg.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController 
    : BaseController<IOrderService, OrderRequestDto, OrderResponseDto>
{
    public OrdersController(IOrderService service) : base(service) {}
}
