using AutoMapper;
using DeliArg.WebApi.Data.Interfaces;
using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;
using DeliArg.WebApi.Services.Interfaces;

namespace DeliArg.WebApi.Services;

public class ProductService
    : BaseService<Product,
        IProductRepository,
        ProductRequestDto,
        ProductResponseDto>,
    IProductService
{
    public ProductService(IMapper mapper, IUnitOfWork unitOfWork, IProductRepository repository)
        : base(mapper, unitOfWork, repository)
    { }
}
