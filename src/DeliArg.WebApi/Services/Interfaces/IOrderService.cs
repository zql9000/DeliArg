using DeliArg.WebApi.Dtos;

namespace DeliArg.WebApi.Services.Interfaces;

public interface IOrderService 
    : IBaseService<OrderRequestDto, OrderResponseDto>
{ }
