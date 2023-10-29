using DeliArg.WebApi.Dtos;

namespace DeliArg.WebApi.Models;

public class ShipmentReceiptItemRequestDto : BaseRequestDto
{
    public int ShipmentReceiptId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}
