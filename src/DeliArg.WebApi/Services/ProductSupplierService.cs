using AutoMapper;
using DeliArg.WebApi.Data.Interfaces;
using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;
using DeliArg.WebApi.Services.Interfaces;

namespace DeliArg.WebApi.Services;

public class ProductSupplierService
    : BaseService<ProductSupplier,
        IProductSupplierRepository,
        ProductSupplierRequestDto,
        ProductSupplierResponseDto>,
    IProductSupplierService
{
    public ProductSupplierService(IMapper mapper, IUnitOfWork unitOfWork, IProductSupplierRepository repository)
        : base(mapper, unitOfWork, repository)
    { }
}
