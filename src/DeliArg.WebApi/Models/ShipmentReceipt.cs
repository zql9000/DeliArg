namespace DeliArg.WebApi.Models;

public class ShipmentReceipt : Base
{
    public int WarehouseId { get; set; }
    public Warehouse Warehouse { get; set; } = default!;
    public int StoreId { get; set; }
    public Store Store { get; set; } = default!;
    public int ShipmentReceiptStatusId { get; set; }
    public ShipmentReceiptStatus ShipmentReceiptStatus { get; set; } = default!;
    public DateTime Date { get; set; }
    public List<ShipmentReceiptItem> ShipmentReceiptItems { get; set; } = default!;
}
