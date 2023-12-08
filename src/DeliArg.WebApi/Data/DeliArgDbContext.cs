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
    public DbSet<StoreStock> StoreStocks { get; set; }
    public DbSet<ShipmentReceipt> ShipmentReceipts { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<ProductSupplier> ProductSuppliers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StoreStock>().Navigation(e => e.Product).AutoInclude();
        modelBuilder.Entity<StoreStock>().Navigation(e => e.Store).AutoInclude();

        modelBuilder.Entity<ShipmentReceipt>().Navigation(e => e.Warehouse).AutoInclude();
        modelBuilder.Entity<ShipmentReceipt>().Navigation(e => e.Store).AutoInclude();
        modelBuilder.Entity<ShipmentReceipt>().Navigation(e => e.ShipmentReceiptStatus).AutoInclude();
        modelBuilder.Entity<ShipmentReceipt>().Navigation(e => e.ShipmentReceiptItems).AutoInclude();
        modelBuilder.Entity<ShipmentReceiptItem>().Navigation(e => e.Product).AutoInclude();

        modelBuilder.Entity<Order>().Navigation(e => e.Supplier).AutoInclude();
        modelBuilder.Entity<Order>().Navigation(e => e.Warehouse).AutoInclude();
        modelBuilder.Entity<Order>().Navigation(e => e.OrderStatus).AutoInclude();
        modelBuilder.Entity<Order>().Navigation(e => e.OrderItems).AutoInclude();
        modelBuilder.Entity<OrderItem>().Navigation(e => e.Product).AutoInclude();

        modelBuilder.Entity<ProductSupplier>().Navigation(e => e.Product).AutoInclude();
        modelBuilder.Entity<ProductSupplier>().Navigation(e => e.Supplier).AutoInclude();

        base.OnModelCreating(modelBuilder);
    }
}
