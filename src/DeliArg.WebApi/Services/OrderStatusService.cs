using AutoMapper;
using DeliArg.WebApi.Data.Interfaces;
using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;
using DeliArg.WebApi.Services.Interfaces;

namespace DeliArg.WebApi.Services;

public class OrderStatusService
    : BaseService<OrderStatus,
        IOrderStatusRepository,
        OrderStatusRequestDto,
        OrderStatusResponseDto>,
    IOrderStatusService
{
    public OrderStatusService(IMapper mapper, IUnitOfWork unitOfWork, IOrderStatusRepository repository)
        : base(mapper, unitOfWork, repository)
    { }
}
