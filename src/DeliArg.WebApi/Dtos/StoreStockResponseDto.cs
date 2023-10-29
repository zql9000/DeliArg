using DeliArg.WebApi.Models;

namespace DeliArg.WebApi.Dtos;

public class StoreStockResponseDto : BaseResponseDto
{
    public Product Product { get; set; } = default!;
    public Store Store { get; set; } = default!;
    public float Price { get; set; }
    public int Quantity { get; set; }
}
