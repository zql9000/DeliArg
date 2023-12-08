namespace DeliArg.WebApi.Models;

public class ProductSupplier : Base
{
    public int ProductId { get; set; }
    public Product Product { get; set; } = default!;
    public int SupplierId { get; set; }
    public Supplier Supplier { get; set; } = default!;
}
