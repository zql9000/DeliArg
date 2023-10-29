namespace DeliArg.WebApi.Models;

public class ShipmentReceiptItem : Base
{
    public int ShipmentReceiptId { get; set; }
    public ShipmentReceipt ShipmentReceipt { get; set; } = default!;
    public int ProductId { get; set; }
    public Product Product { get; set; } = default!;
    public int Quantity { get; set; }
}
