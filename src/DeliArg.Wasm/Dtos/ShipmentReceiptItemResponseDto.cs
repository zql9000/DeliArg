using System.Text.Json.Serialization;

namespace DeliArg.Wasm.Dtos;

public class ShipmentReceiptItemResponseDto : BaseResponseDto
{
    [JsonIgnore]
    public ShipmentReceipt ShipmentReceipt { get; set; } = default!;
    public Product Product { get; set; } = default!;
    public int Quantity { get; set; }
}
