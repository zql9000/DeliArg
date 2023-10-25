using AutoMapper;
using DeliArg.WebApi.Data.Interfaces;
using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;
using DeliArg.WebApi.Services.Interfaces;

namespace DeliArg.WebApi.Services;

public class StoreService
    : BaseService<Store,
        IStoreRepository,
        StoreRequestDto,
        StoreResponseDto>,
    IStoreService
{
    public StoreService(IMapper mapper, IUnitOfWork unitOfWork, IStoreRepository repository)
        : base(mapper, unitOfWork, repository)
    { }
}
