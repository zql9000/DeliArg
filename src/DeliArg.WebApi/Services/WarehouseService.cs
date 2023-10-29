using AutoMapper;
using DeliArg.WebApi.Data.Interfaces;
using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;
using DeliArg.WebApi.Services.Interfaces;

namespace DeliArg.WebApi.Services;

public class WarehouseService
    : BaseService<Warehouse,
        IWarehouseRepository,
        WarehouseRequestDto,
        WarehouseResponseDto>,
    IWarehouseService
{
    public WarehouseService(IMapper mapper, IUnitOfWork unitOfWork, IWarehouseRepository repository)
        : base(mapper, unitOfWork, repository)
    { }
}
