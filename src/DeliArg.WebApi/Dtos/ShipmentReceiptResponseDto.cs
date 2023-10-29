using DeliArg.WebApi.Dtos;

namespace DeliArg.WebApi.Models;

public class ShipmentReceiptResponseDto : BaseResponseDto
{
    public Warehouse Warehouse { get; set; } = default!;
    public Store Store { get; set; } = default!;
    public ShipmentReceiptStatus ShipmentReceiptStatus { get; set; } = default!;
    public DateTime Date { get; set; }
    public List<ShipmentReceiptItemResponseDto> ShipmentReceiptItems { get; set; } = default!;
}
