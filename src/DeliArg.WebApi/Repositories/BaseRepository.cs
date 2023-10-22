using DeliArg.WebApi.Data;
using DeliArg.WebApi.Models;
using DeliArg.WebApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DeliArg.WebApi.Repositories;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : Base
{
    private readonly DeliArgDbContext context;
    protected DbSet<T> Entities => context.Set<T>();


    public BaseRepository(DeliArgDbContext context)
    {
        this.context = context;
    }

    public IQueryable<T> GetAll()
    {
        return Entities;
    }

    public async Task<T?> GetById(int id)
    {
        return await Entities.FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task<T> Insert(T entity)
    {
        EntityEntry<T> insertedValue = await Entities.AddAsync(entity);
        return insertedValue.Entity;
    }

    public void Update(T entity)
    {
        Entities.Update(entity);
    }

    public async Task<bool> SoftDelete(int id)
    {
        T? entity = await GetById(id);

        if (entity is null)
            return false;

        Update(entity);
        return true;
    }

    public async Task<bool> HardDelete(int id)
    {
        T? entity = await GetById(id);

        if (entity is null)
            return false;

        Entities.Remove(entity);
        return true;
    }
}
