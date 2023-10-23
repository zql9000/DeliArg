using DeliArg.WebApi.Models;

namespace DeliArg.WebApi.Services.Interfaces;

public interface IShipmentReceiptStatusService 
    : IBaseService<ShipmentReceiptStatusRequestDto, ShipmentReceiptStatusResponseDto>
{ }
