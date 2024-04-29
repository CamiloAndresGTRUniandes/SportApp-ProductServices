namespace SportApp.ProductsServices.Domain.Subscription.Repositories ;

    public interface ISubscriptionRepository
    {
        Task SaveAndPublishAsync(Subscription subscription);
        Task<bool> GetActiveByUserIdAsync(Guid id, DateTime starDate, DateTime endDate);
    }
