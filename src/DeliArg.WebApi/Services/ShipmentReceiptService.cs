using AutoMapper;
using DeliArg.WebApi.Data.Interfaces;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;
using DeliArg.WebApi.Services.Interfaces;

namespace DeliArg.WebApi.Services;

public class ShipmentReceiptService 
    : BaseService<ShipmentReceipt, 
        IShipmentReceiptRepository, 
        ShipmentReceiptRequestDto, 
        ShipmentReceiptResponseDto>, 
    IShipmentReceiptService
{
    public ShipmentReceiptService(IMapper mapper, IUnitOfWork unitOfWork, IShipmentReceiptRepository repository)
        : base(mapper, unitOfWork, repository)
    { }
}
