using DeliArg.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliArg.WebApi.Data;

public class DeliArgDbContext : DbContext
{
    public DeliArgDbContext(DbContextOptions<DeliArgDbContext> options) : base(options) {}

    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<OrderStatus> OrderStatuses { get; set; }
}
