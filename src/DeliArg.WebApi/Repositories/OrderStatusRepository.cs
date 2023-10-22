using DeliArg.WebApi.Data;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;

namespace DeliArg.WebApi.Repositories;

public class OrderStatusRepository : BaseRepository<OrderStatus>, IOrderStatusRepository
{
    public OrderStatusRepository(DeliArgDbContext context) : base(context) { }
}
