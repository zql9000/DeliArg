using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DeliArg.WebApi.Controllers;

[ApiController]
public class BaseController<TService, TRequest, TResponse> 
    : ControllerBase 
    where TService : IBaseService<TRequest, TResponse>
    where TRequest : BaseRequestDto
    where TResponse : BaseResponseDto
{
    private readonly TService service;

    public BaseController(TService service)
    {
        this.service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TResponse>>> GetAll()
    {
        var entities = await service.GetAll();

        return Ok(entities);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TResponse>> GetById(int id)
    {
        TResponse? entity = await service.GetById(id);

        if (entity == null)
        {
            return NotFound();
        }

        return Ok(entity);
    }

    [HttpPost]
    public async Task<ActionResult<TResponse>> Create(TRequest entity)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        TResponse entityCreated = await service.Create(entity);

        return CreatedAtAction(nameof(GetById), new { id = entityCreated.Id }, entityCreated);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, TRequest entity)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await service.Update(id, entity);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(int id)
    {
        bool result = await service.Delete(id);

        return Ok(result);
    }
}
