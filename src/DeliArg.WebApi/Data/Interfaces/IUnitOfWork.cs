namespace DeliArg.WebApi.Data.Interfaces;

public interface IUnitOfWork
{
    Task CompleteAsync();
}
