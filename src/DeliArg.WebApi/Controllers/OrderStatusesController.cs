using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DeliArg.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderStatusesController : ControllerBase
{
    private readonly IOrderStatusService orderStatusService;

    public OrderStatusesController(IOrderStatusService orderStatusService)
    {
        this.orderStatusService = orderStatusService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<OrderStatusResponseDto>>> GetAll()
    {
        var orderStatuss = await orderStatusService.GetAll();

        return Ok(orderStatuss);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<OrderStatusResponseDto>> GetById(int id)
    {
        OrderStatusResponseDto? orderStatus = await orderStatusService.GetById(id);

        if (orderStatus == null)
        {
            return NotFound();
        }

        return Ok(orderStatus);
    }

    [HttpPost]
    public async Task<ActionResult<OrderStatusResponseDto>> Create(OrderStatusRequestDto orderStatus)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        OrderStatusResponseDto orderStatusCreated = await orderStatusService.Create(orderStatus);

        return CreatedAtAction(nameof(GetById), new { id = orderStatusCreated.Id }, orderStatusCreated);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, OrderStatusRequestDto orderStatus)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await orderStatusService.Update(id, orderStatus);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(int id)
    {
        bool result = await orderStatusService.Delete(id);

        return Ok(result);
    }
}
