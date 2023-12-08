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
        CreateMap<ShipmentReceipt, ShipmentReceiptResponseDto>();
        CreateMap<ShipmentReceiptRequestDto, ShipmentReceipt>();
        CreateMap<ShipmentReceiptItem, ShipmentReceiptItemResponseDto>();
        CreateMap<ShipmentReceiptItemRequestDto, ShipmentReceiptItem>();
        CreateMap<Order, OrderResponseDto>();
        CreateMap<OrderRequestDto, Order>();
        CreateMap<OrderItem, OrderItemResponseDto>();
        CreateMap<OrderItemRequestDto, OrderItem>();
        CreateMap<ProductSupplier, ProductSupplierResponseDto>();
        CreateMap<ProductSupplierRequestDto, ProductSupplier>();
    }
}
