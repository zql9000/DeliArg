using DeliArg.WebApi.Models;

namespace DeliArg.WebApi.Services.Interfaces;

public interface IShipmentReceiptService 
    : IBaseService<ShipmentReceiptRequestDto, ShipmentReceiptResponseDto>
{ }
