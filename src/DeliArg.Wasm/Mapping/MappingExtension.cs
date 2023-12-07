using DeliArg.Wasm.Dtos;

namespace DeliArg.Wasm.Mapping;

public static class MappingExtension
{
    public static OrderStatusRequestDto ToRequest(this OrderStatusResponseDto orderResponseDto)
    {
        OrderStatusRequestDto result = new()
        {
            Description = orderResponseDto.Description,
        };

        return result;
    }

    public static ShipmentReceiptStatusRequestDto ToRequest(this ShipmentReceiptStatusResponseDto shipmentReceiptResponseDto)
    {
        ShipmentReceiptStatusRequestDto result = new()
        {
            Description = shipmentReceiptResponseDto.Description,
        };

        return result;
    }

    public static StoreRequestDto ToRequest(this StoreResponseDto storeResponseDto)
    {
        StoreRequestDto result = new()
        {
            Name = storeResponseDto.Name,
            Address = storeResponseDto.Address,
        };

        return result;
    }

    public static StoreStockRequestDto ToRequest(this StoreStockResponseDto storeStockResponseDto)
    {
        StoreStockRequestDto result = new()
        {
            ProductId = storeStockResponseDto.Product.Id,
            StoreId = storeStockResponseDto.Store.Id,
            Price = storeStockResponseDto.Price,
            Quantity = storeStockResponseDto.Quantity,
        };

        return result;
    }

    public static WarehouseRequestDto ToRequest(this WarehouseResponseDto warehouseResponseDto)
    {
        WarehouseRequestDto result = new()
        {
            Name = warehouseResponseDto.Name,
            Address = warehouseResponseDto.Address,
        };

        return result;
    }
}
