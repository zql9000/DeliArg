using DeliArg.WebApi.Data;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;

namespace DeliArg.WebApi.Repositories;

public class ProductSupplierRepository : BaseRepository<ProductSupplier>, IProductSupplierRepository
{
    public ProductSupplierRepository(DeliArgDbContext context) : base(context) {}
}
