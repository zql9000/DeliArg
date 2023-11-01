namespace DeliArg.WebApi.Dtos;

public class ShipmentReceiptResponseDto : BaseResponseDto
{
    public WarehouseResponseDto Warehouse { get; set; } = default!;
    public StoreResponseDto Store { get; set; } = default!;
    public ShipmentReceiptStatusResponseDto ShipmentReceiptStatus { get; set; } = default!;
    public DateTime Date { get; set; }
    public List<ShipmentReceiptItemResponseDto> ShipmentReceiptItems { get; set; } = default!;
}
