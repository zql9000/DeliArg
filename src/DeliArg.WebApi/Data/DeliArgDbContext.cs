using DeliArg.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliArg.WebApi.Data;

public class DeliArgDbContext : DbContext
{
    public DeliArgDbContext(DbContextOptions<DeliArgDbContext> options) : base(options) {}

    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<OrderStatus> OrderStatuses { get; set; }
    public DbSet<ShipmentReceiptStatus> ShipmentReceiptStatuses { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
}
