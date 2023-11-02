using AutoMapper;
using DeliArg.WebApi.Data.Interfaces;
using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;
using DeliArg.WebApi.Services.Interfaces;

namespace DeliArg.WebApi.Services;

public class ShipmentReceiptStatusService 
    : BaseService<ShipmentReceiptStatus, 
        IShipmentReceiptStatusRepository, 
        ShipmentReceiptStatusRequestDto, 
        ShipmentReceiptStatusResponseDto>, 
    IShipmentReceiptStatusService
{
    public ShipmentReceiptStatusService(IMapper mapper, IUnitOfWork unitOfWork, IShipmentReceiptStatusRepository repository)
        : base(mapper, unitOfWork, repository)
    { }
}
