using System.Text.Json.Serialization;

namespace DeliArg.Wasm.Dtos;

public class ShipmentReceiptItemResponseDto : BaseResponseDto
{
    [JsonIgnore]
    public ShipmentReceiptResponseDto ShipmentReceipt { get; set; } = default!;
    public ProductResponseDto Product { get; set; } = default!;
    public int Quantity { get; set; }
}
