using System.Text.Json.Serialization;

namespace DeliArg.Wasm.Dtos;

public class OrderItemResponseDto : BaseResponseDto
{
    [JsonIgnore]
    public Order Order { get; set; } = default!;
    public Product Product { get; set; } = default!;
    public float Price { get; set; }
    public int Quantity { get; set; }
}
