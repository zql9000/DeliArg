using System.Text.Json.Serialization;

namespace DeliArg.WebApi.Dtos;

public class OrderItemResponseDto : BaseResponseDto
{
    [JsonIgnore]
    public OrderResponseDto Order { get; set; } = default!;
    public ProductResponseDto Product { get; set; } = default!;
    public float Price { get; set; }
    public int Quantity { get; set; }
}
