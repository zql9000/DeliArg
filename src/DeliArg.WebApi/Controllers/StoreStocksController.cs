using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DeliArg.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StoreStocksController
    : BaseController<IStoreStockService, StoreStockRequestDto, StoreStockResponseDto>
{
    public StoreStocksController(IStoreStockService service) : base(service) { }
}
