using AutoMapper;
using DeliArg.WebApi.Data.Interfaces;
using DeliArg.WebApi.Dtos;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;
using DeliArg.WebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DeliArg.WebApi.Services;

public class BaseService<TModel, TRepository, TRequest, TResponse> 
    : IBaseService<TRequest, TResponse> 
    where TModel : Base 
    where TRepository : IBaseRepository<TModel> 
    where TRequest : BaseRequestDto
    where TResponse : BaseResponseDto
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    private readonly TRepository repository;

    public BaseService(IMapper mapper, IUnitOfWork unitOfWork, TRepository repository)
    {
        this.mapper = mapper;
        this.unitOfWork = unitOfWork;
        this.repository = repository;
    }

    public async Task<IEnumerable<TResponse>> GetAll()
    {
        var entities = await repository.GetAll().ToListAsync();
        var response = mapper.Map<List<TModel>, IEnumerable<TResponse>>(entities);
        return response;
    }

    public async Task<TResponse?> GetById(int id)
    {
        var entity = await repository.GetById(id);
        var response = mapper.Map<TModel?, TResponse?>(entity);
        return response;
    }

    public async Task<TResponse> Create(TRequest entity)
    {
        TModel entityToInsert = mapper.Map<TRequest, TModel>(entity);
        TModel entityInserted = await repository.Insert(entityToInsert);
        await unitOfWork.CompleteAsync();
        TResponse? dbEntity = await GetById(entityInserted.Id);
        TResponse response;
        if (dbEntity is null)
            response = mapper.Map<TModel, TResponse>(entityInserted);
        else
            response = dbEntity;

        return response;
    }

    public async Task Update(int id, TRequest entity)
    {
        TModel entityToModify = mapper.Map<TRequest, TModel>(entity);
        entityToModify.Id = id;
        repository.Update(entityToModify);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> Delete(int id)
    {
        bool result = await repository.HardDelete(id);
        await unitOfWork.CompleteAsync();
        return result;
    }
}
