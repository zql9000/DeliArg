using DeliArg.WebApi.Dtos;

namespace DeliArg.WebApi.Services.Interfaces;

public interface IBaseService<TRequest, TResponse> 
    where TRequest : BaseRequestDto 
    where TResponse : BaseResponseDto
{
    Task<IEnumerable<TResponse>> GetAll();
    Task<TResponse?> GetById(int id);
    Task<TResponse> Create(TRequest entity);
    Task Update(int id, TRequest entity);
    Task<bool> Delete(int id);
}
