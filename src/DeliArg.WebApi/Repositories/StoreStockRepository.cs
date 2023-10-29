using DeliArg.WebApi.Data;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;

namespace DeliArg.WebApi.Repositories;

public class StoreStockRepository : BaseRepository<StoreStock>, IStoreStockRepository
{
    public StoreStockRepository(DeliArgDbContext context) : base(context) {}
}
