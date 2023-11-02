using DeliArg.WebApi.Dtos;

namespace DeliArg.WebApi.Services.Interfaces;

public interface IShipmentReceiptStatusService 
    : IBaseService<ShipmentReceiptStatusRequestDto, ShipmentReceiptStatusResponseDto>
{ }
