namespace DeliArg.WebApi.Dtos;

public class ShipmentReceiptItemRequestDto : BaseRequestDto
{
    public int ShipmentReceiptId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}
