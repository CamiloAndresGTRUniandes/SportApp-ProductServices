namespace SportApp.ProductsServices.Domain.Goals.Repositories ;
using Common.ValueObjects;

    public interface IGoalRepository
    {
        Task SaveAndPublishAsync(Goal goal);
        Task<Goal?> GetByIdAsync(Guid id);
        Task<Goal?> GetByNameAsync(Name name);
    }
