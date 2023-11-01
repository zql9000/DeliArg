using DeliArg.WebApi.Dtos;

namespace DeliArg.WebApi.Services.Interfaces;

public interface IShipmentReceiptService 
    : IBaseService<ShipmentReceiptRequestDto, ShipmentReceiptResponseDto>
{ }
