using AutoMapper;
using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Models;

namespace DeliArg.WebApi.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Supplier, SupplierResponseDto>();
        CreateMap<SupplierRequestDto, Supplier>();
    }
}
