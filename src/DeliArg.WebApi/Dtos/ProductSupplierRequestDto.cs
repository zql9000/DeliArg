namespace DeliArg.WebApi.Dtos;

public class ProductSupplierRequestDto : BaseRequestDto
{
    public int ProductId { get; set; }
    public int SupplierId { get; set; }
}
