using DeliArg.WebApi.Dtos;

namespace DeliArg.WebApi.Services.Interfaces;

public interface IOrderStatusService
    : IBaseService<OrderStatusRequestDto, OrderStatusResponseDto>
{ }
