using DeliArg.WebApi.Data;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;

namespace DeliArg.WebApi.Repositories;

public class ShipmentReceiptRepository : BaseRepository<ShipmentReceipt>, IShipmentReceiptRepository
{
    public ShipmentReceiptRepository(DeliArgDbContext context) : base(context) { }
}
