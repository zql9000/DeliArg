using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DeliArg.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SuppliersController : ControllerBase
{
    private readonly ISupplierService supplierService;

    public SuppliersController(ISupplierService supplierService)
    {
        this.supplierService = supplierService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SupplierResponseDto>>> GetAll()
    {
        var suppliers = await supplierService.GetAll();

        return Ok(suppliers);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SupplierResponseDto>> GetById(int id)
    {
        SupplierResponseDto? supplier = await supplierService.GetById(id);

        if (supplier == null)
        {
            return NotFound();
        }

        return Ok(supplier);
    }

    [HttpPost]
    public async Task<ActionResult<SupplierResponseDto>> Create(SupplierRequestDto supplier)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        SupplierResponseDto supplierCreated = await supplierService.Create(supplier);

        return CreatedAtAction(nameof(GetById), new { id = supplierCreated.Id }, supplierCreated);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, SupplierRequestDto supplier)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await supplierService.Update(id, supplier);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(int id)
    {
        bool result = await supplierService.Delete(id);

        return Ok(result);
    }
}
