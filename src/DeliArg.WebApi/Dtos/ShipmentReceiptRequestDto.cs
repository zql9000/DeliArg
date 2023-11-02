namespace DeliArg.WebApi.Dtos;

public class ShipmentReceiptRequestDto : BaseRequestDto
{
    public int WarehouseId { get; set; }
    public int StoreId { get; set; }
    public int ShipmentReceiptStatusId { get; set; }
    public DateTime Date { get; set; }
    public List<ShipmentReceiptItemRequestDto> ShipmentReceiptItems { get; set; } = default!;
}
