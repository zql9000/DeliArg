using DeliArg.WebApi.Models;

namespace DeliArg.WebApi.Services.Interfaces;

public interface IOrderService 
    : IBaseService<OrderRequestDto, OrderResponseDto>
{ }
