namespace DeliArg.WebApi.Models;

public class OrderItem : Base
{
    public int OrderId { get; set; }
    public Order Order { get; set; } = default!;
    public int ProductId { get; set; }
    public Product Product { get; set; } = default!;
    public float Price { get; set; }
    public int Quantity { get; set; }
}
