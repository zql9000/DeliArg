using DeliArg.WebApi.Dtos;

namespace DeliArg.WebApi.Services.Interfaces;

public interface IProductService
    : IBaseService<ProductRequestDto, ProductResponseDto>
{ }
