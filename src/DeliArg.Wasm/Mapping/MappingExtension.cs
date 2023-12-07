using DeliArg.Wasm.Dtos;

namespace DeliArg.Wasm.Mapping;

public static class MappingExtension
{
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
}
