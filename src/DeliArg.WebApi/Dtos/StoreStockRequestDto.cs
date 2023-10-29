namespace DeliArg.WebApi.Dtos;

public class StoreStockRequestDto : BaseRequestDto
{
    public int ProductId { get; set; }
    public int StoreId { get; set; }
    public float Price { get; set; }
    public int Quantity { get; set; }
}
