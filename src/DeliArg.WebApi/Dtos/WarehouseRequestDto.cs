namespace DeliArg.WebApi.Dtos;

public class WarehouseRequestDto : BaseRequestDto
{
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
}
