using DeliArg.WebApi.Dtos;

namespace DeliArg.WebApi.Models;

public class ShipmentReceiptStatusResponseDto : BaseResponseDto
{
    public string Description { get; set; } = string.Empty;
}
