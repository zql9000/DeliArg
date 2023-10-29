namespace DeliArg.WebApi.Models;

public class Order : Base
{
    public int SupplierId { get; set; }
    public Supplier Supplier { get; set; } = default!;
    public int WarehouseId { get; set; }
    public Warehouse Warehouse { get; set; } = default!;
    public int OrderStatusId { get; set; }
    public OrderStatus OrderStatus { get; set; } = default!;
    public float TotalAmount { get; set; }
    public DateTime Date { get; set; }
    public List<OrderItem> OrderItems { get; set; } = default!;
}
