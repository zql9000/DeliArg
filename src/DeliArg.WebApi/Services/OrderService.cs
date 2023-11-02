using AutoMapper;
using DeliArg.WebApi.Data.Interfaces;
using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;
using DeliArg.WebApi.Services.Interfaces;

namespace DeliArg.WebApi.Services;

public class OrderService 
    : BaseService<Order, 
        IOrderRepository, 
        OrderRequestDto, 
        OrderResponseDto>, 
    IOrderService
{
    public OrderService(IMapper mapper, IUnitOfWork unitOfWork, IOrderRepository repository)
        : base(mapper, unitOfWork, repository)
    { }
}
