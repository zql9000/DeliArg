namespace DeliArg.Wasm.Dtos;

public class StoreStockResponseDto : BaseResponseDto
{
    public ProductResponseDto Product { get; set; } = default!;
    public StoreResponseDto Store { get; set; } = default!;
    public float Price { get; set; }
    public int Quantity { get; set; }
}
