using DeliArg.WebApi.Models;

namespace DeliArg.WebApi.Repositories.Interfaces;

public interface IBaseRepository<T> where T : Base
{
    IQueryable<T> GetAll();
    Task<T?> GetById(int id);
    Task<T> Insert(T entity);
    void Update(T entity);
    Task<bool> SoftDelete(int id);
    Task<bool> HardDelete(int id);
}
