using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DeliArg.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StoresController
    : BaseController<IStoreService, StoreRequestDto, StoreResponseDto>
{
    public StoresController(IStoreService service) : base(service) { }
}
