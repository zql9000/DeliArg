namespace DeliArg.WebApi.Models;

public class StoreStock : Base
{
    public int ProductId { get; set; }
    public Product Product { get; set; } = default!;
    public int StoreId { get; set; }
    public Store Store { get; set; } = default!;
    public float Price { get; set; }
    public int Quantity { get; set; }
}
