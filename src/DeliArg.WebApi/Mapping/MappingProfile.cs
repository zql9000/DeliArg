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
        CreateMap<OrderStatus, OrderStatusResponseDto>();
        CreateMap<OrderStatusRequestDto, OrderStatus>();
        CreateMap<ShipmentReceiptStatus, ShipmentReceiptStatusResponseDto>();
        CreateMap<ShipmentReceiptStatusRequestDto, ShipmentReceiptStatus>();
        CreateMap<Product, ProductResponseDto>();
        CreateMap<ProductRequestDto, Product>();
        CreateMap<Store, StoreResponseDto>();
        CreateMap<StoreRequestDto, Store>();
        CreateMap<Warehouse, WarehouseResponseDto>();
        CreateMap<WarehouseRequestDto, Warehouse>();
        CreateMap<StoreStock, StoreStockResponseDto>();
        CreateMap<StoreStockRequestDto, StoreStock>();
    }
}
