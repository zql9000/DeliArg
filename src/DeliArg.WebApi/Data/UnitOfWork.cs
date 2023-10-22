using DeliArg.WebApi.Data.Interfaces;

namespace DeliArg.WebApi.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly DeliArgDbContext context;

    public UnitOfWork(DeliArgDbContext context)
    {
        this.context = context;
    }

    public async Task CompleteAsync()
    {
        await context.SaveChangesAsync();
    }
}
