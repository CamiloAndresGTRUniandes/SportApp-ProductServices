namespace SportApp.ProductsServices.Domain.Subscription.Repositories ;

    public interface ISubscriptionRepository
    {
        Task SaveAndPublishAsync(Subscription subscription);
        Task<Subscription?> GetByUserIdAsync(Guid id);
    }
