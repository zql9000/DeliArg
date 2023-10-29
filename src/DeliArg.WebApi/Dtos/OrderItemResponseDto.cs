using DeliArg.WebApi.Dtos;
using System.Text.Json.Serialization;

namespace DeliArg.WebApi.Models;

public class OrderItemResponseDto : BaseResponseDto
{
    [JsonIgnore]
    public Order Order { get; set; } = default!;
    public Product Product { get; set; } = default!;
    public float Price { get; set; }
    public int Quantity { get; set; }
}
