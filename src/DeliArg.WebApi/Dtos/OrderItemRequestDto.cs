namespace DeliArg.WebApi.Dtos;

public class OrderItemRequestDto : BaseRequestDto
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public float Price { get; set; }
    public int Quantity { get; set; }
}
