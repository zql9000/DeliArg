using AutoMapper;
using DeliArg.WebApi.Data.Interfaces;
using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;
using DeliArg.WebApi.Services.Interfaces;

namespace DeliArg.WebApi.Services;

public class SupplierService
    : BaseService<Supplier,
        ISupplierRepository,
        SupplierRequestDto,
        SupplierResponseDto>,
    ISupplierService
{
    public SupplierService(IMapper mapper, IUnitOfWork unitOfWork, ISupplierRepository repository)
        : base(mapper, unitOfWork, repository)
    { }
}
