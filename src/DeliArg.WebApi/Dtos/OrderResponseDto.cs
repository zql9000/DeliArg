using DeliArg.WebApi.Dtos;

namespace DeliArg.WebApi.Models;

public class OrderResponseDto : BaseResponseDto
{
    public Supplier Supplier { get; set; } = default!;
    public Warehouse Warehouse { get; set; } = default!;
    public OrderStatus OrderStatus { get; set; } = default!;
    public float TotalAmount { get; set; }
    public DateTime Date { get; set; }
    public List<OrderItemResponseDto> OrderItems { get; set; } = default!;
}
