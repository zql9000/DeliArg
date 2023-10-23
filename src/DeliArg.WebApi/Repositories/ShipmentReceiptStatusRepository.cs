using DeliArg.WebApi.Data;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;

namespace DeliArg.WebApi.Repositories;

public class ShipmentReceiptStatusRepository : BaseRepository<ShipmentReceiptStatus>, IShipmentReceiptStatusRepository
{
    public ShipmentReceiptStatusRepository(DeliArgDbContext context) : base(context) { }
}
