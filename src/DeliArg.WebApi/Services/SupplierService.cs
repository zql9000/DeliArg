using AutoMapper;
using DeliArg.WebApi.Data.Interfaces;
using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;
using DeliArg.WebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DeliArg.WebApi.Services;

public class SupplierService : ISupplierService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    private readonly ISupplierRepository repository;

    public SupplierService(IMapper mapper, IUnitOfWork unitOfWork, ISupplierRepository repository)
    {
        this.mapper = mapper;
        this.unitOfWork = unitOfWork;
        this.repository = repository;
    }

    public async Task<IEnumerable<SupplierResponseDto>> GetAll()
    {
        var suppliers = await repository.GetAll().ToListAsync();
        var response = mapper.Map<List<Supplier>, IEnumerable<SupplierResponseDto>>(suppliers);
        return response;
    }

    public async Task<SupplierResponseDto?> GetById(int Id)
    {
        var supplier = await repository.GetById(Id);
        var response = mapper.Map<Supplier?, SupplierResponseDto?>(supplier);
        return response;
    }

    public async Task<SupplierResponseDto> Create(SupplierRequestDto supplier)
    {
        Supplier supplierToInsert = mapper.Map<SupplierRequestDto, Supplier>(supplier);
        Supplier supplierInserted = await repository.Insert(supplierToInsert);
        await unitOfWork.CompleteAsync();
        SupplierResponseDto response = mapper.Map<Supplier, SupplierResponseDto>(supplierInserted);
        return response;
    }

    public async Task Update(int id, SupplierRequestDto supplier)
    {
        Supplier supplierToModify = mapper.Map<SupplierRequestDto, Supplier>(supplier);
        supplierToModify.Id = id;
        repository.Update(supplierToModify);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> Delete(int id)
    {
        bool result = await repository.HardDelete(id);
        await unitOfWork.CompleteAsync();
        return result;
    }
}
