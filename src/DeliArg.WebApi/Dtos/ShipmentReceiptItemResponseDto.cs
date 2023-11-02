using System.Text.Json.Serialization;

namespace DeliArg.WebApi.Dtos;

public class ShipmentReceiptItemResponseDto : BaseResponseDto
{
    [JsonIgnore]
    public ShipmentReceiptResponseDto ShipmentReceipt { get; set; } = default!;
    public ProductResponseDto Product { get; set; } = default!;
    public int Quantity { get; set; }
}
