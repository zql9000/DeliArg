using DeliArg.WebApi.Dtos;

namespace DeliArg.WebApi.Services.Interfaces;

public interface ISupplierService
{
    Task<IEnumerable<SupplierResponseDto>> GetAll();
    Task<SupplierResponseDto?> GetById(int id);
    Task<SupplierResponseDto> Create(SupplierRequestDto supplier);
    Task Update(int id, SupplierRequestDto supplier);
    Task<bool> Delete(int id);
}
