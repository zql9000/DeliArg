using DeliArg.WebApi.Data;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;

namespace DeliArg.WebApi.Repositories;

public class StoreRepository : BaseRepository<Store>, IStoreRepository
{
    public StoreRepository(DeliArgDbContext context) : base(context) {}
}
