using DeliArg.WebApi.Data;
using DeliArg.WebApi.Data.Interfaces;
using DeliArg.WebApi.Repositories;
using DeliArg.WebApi.Repositories.Interfaces;
using DeliArg.WebApi.Services;
using DeliArg.WebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DeliArg.WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddAutoMapper(typeof(Program));
        builder.Services.AddDbContext<DeliArgDbContext>(options => {
            options.UseSqlServer(builder.Configuration["DeliArg:ConnectionString"]);
        });
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

        builder.Services.AddScoped<ISupplierService, SupplierService>();
        builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();
        builder.Services.AddScoped<IOrderStatusService, OrderStatusService>();
        builder.Services.AddScoped<IOrderStatusRepository, OrderStatusRepository>();
        builder.Services.AddScoped<IShipmentReceiptStatusService, ShipmentReceiptStatusService>();
        builder.Services.AddScoped<IShipmentReceiptStatusRepository, ShipmentReceiptStatusRepository>();
        builder.Services.AddScoped<IProductService, ProductService>();
        builder.Services.AddScoped<IProductRepository, ProductRepository>();
        builder.Services.AddScoped<IStoreService, StoreService>();
        builder.Services.AddScoped<IStoreRepository, StoreRepository>();
        builder.Services.AddScoped<IWarehouseService, WarehouseService>();
        builder.Services.AddScoped<IWarehouseRepository, WarehouseRepository>();
        builder.Services.AddScoped<IStoreStockService, StoreStockService>();
        builder.Services.AddScoped<IStoreStockRepository, StoreStockRepository>();
        builder.Services.AddScoped<IShipmentReceiptService, ShipmentReceiptService>();
        builder.Services.AddScoped<IShipmentReceiptRepository, ShipmentReceiptRepository>();
        builder.Services.AddScoped<IOrderService, OrderService>();
        builder.Services.AddScoped<IOrderRepository, OrderRepository>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
