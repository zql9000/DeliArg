using AutoMapper;
using DeliArg.WebApi.Data.Interfaces;
using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;
using DeliArg.WebApi.Services.Interfaces;

namespace DeliArg.WebApi.Services;

public class StoreStockService
    : BaseService<StoreStock,
        IStoreStockRepository,
        StoreStockRequestDto,
        StoreStockResponseDto>,
    IStoreStockService
{
    public StoreStockService(IMapper mapper, IUnitOfWork unitOfWork, IStoreStockRepository repository)
        : base(mapper, unitOfWork, repository)
    { }
}
