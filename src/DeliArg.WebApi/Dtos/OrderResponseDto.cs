namespace DeliArg.WebApi.Dtos;

public class OrderResponseDto : BaseResponseDto
{
    public SupplierResponseDto Supplier { get; set; } = default!;
    public WarehouseResponseDto Warehouse { get; set; } = default!;
    public OrderStatusResponseDto OrderStatus { get; set; } = default!;
    public float TotalAmount { get; set; }
    public DateTime Date { get; set; }
    public List<OrderItemResponseDto> OrderItems { get; set; } = default!;
}
