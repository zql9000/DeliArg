using DeliArg.WebApi.Dtos;
using System.Text.Json.Serialization;

namespace DeliArg.WebApi.Models;

public class ShipmentReceiptItemResponseDto : BaseResponseDto
{
    [JsonIgnore]
    public ShipmentReceipt ShipmentReceipt { get; set; } = default!;
    public Product Product { get; set; } = default!;
    public int Quantity { get; set; }
}
