namespace DeliArg.Wasm.Dtos;

public class OrderRequestDto : BaseRequestDto
{
    public int SupplierId { get; set; }
    public int WarehouseId { get; set; }
    public int OrderStatusId { get; set; }
    public float TotalAmount { get; set; }
    public DateTime Date { get; set; }
    public List<OrderItemRequestDto> OrderItems { get; set; } = default!;
}
