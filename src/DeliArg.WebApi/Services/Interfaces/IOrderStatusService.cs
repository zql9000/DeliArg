using DeliArg.WebApi.Dtos;

namespace DeliArg.WebApi.Services.Interfaces;

public interface IOrderStatusService
{
    Task<IEnumerable<OrderStatusResponseDto>> GetAll();
    Task<OrderStatusResponseDto?> GetById(int id);
    Task<OrderStatusResponseDto> Create(OrderStatusRequestDto supplier);
    Task Update(int id, OrderStatusRequestDto supplier);
    Task<bool> Delete(int id);
}
