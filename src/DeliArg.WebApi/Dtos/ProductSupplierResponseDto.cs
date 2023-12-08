namespace DeliArg.WebApi.Dtos;

public class ProductSupplierResponseDto : BaseResponseDto
{
    public ProductResponseDto Product { get; set; } = default!;
    public SupplierResponseDto Supplier { get; set; } = default!;
}
