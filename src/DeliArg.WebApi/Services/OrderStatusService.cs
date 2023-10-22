using AutoMapper;
using DeliArg.WebApi.Data.Interfaces;
using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;
using DeliArg.WebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DeliArg.WebApi.Services;

public class OrderStatusService : IOrderStatusService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    private readonly IOrderStatusRepository repository;

    public OrderStatusService(IMapper mapper, IUnitOfWork unitOfWork, IOrderStatusRepository repository)
    {
        this.mapper = mapper;
        this.unitOfWork = unitOfWork;
        this.repository = repository;
    }

    public async Task<IEnumerable<OrderStatusResponseDto>> GetAll()
    {
        var orderStatuss = await repository.GetAll().ToListAsync();
        var response = mapper.Map<List<OrderStatus>, IEnumerable<OrderStatusResponseDto>>(orderStatuss);
        return response;
    }

    public async Task<OrderStatusResponseDto?> GetById(int Id)
    {
        var orderStatus = await repository.GetById(Id);
        var response = mapper.Map<OrderStatus?, OrderStatusResponseDto?>(orderStatus);
        return response;
    }

    public async Task<OrderStatusResponseDto> Create(OrderStatusRequestDto orderStatus)
    {
        OrderStatus orderStatusToInsert = mapper.Map<OrderStatusRequestDto, OrderStatus>(orderStatus);
        OrderStatus orderStatusInserted = await repository.Insert(orderStatusToInsert);
        await unitOfWork.CompleteAsync();
        OrderStatusResponseDto response = mapper.Map<OrderStatus, OrderStatusResponseDto>(orderStatusInserted);
        return response;
    }

    public async Task Update(int id, OrderStatusRequestDto orderStatus)
    {
        OrderStatus orderStatusToModify = mapper.Map<OrderStatusRequestDto, OrderStatus>(orderStatus);
        orderStatusToModify.Id = id;
        repository.Update(orderStatusToModify);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> Delete(int id)
    {
        bool result = await repository.HardDelete(id);
        await unitOfWork.CompleteAsync();
        return result;
    }
}
