using DeliArg.WebApi.Dtos;

namespace DeliArg.WebApi.Models;

public class ShipmentReceiptStatusRequestDto : BaseRequestDto
{
    public string Description { get; set; } = string.Empty;
}
