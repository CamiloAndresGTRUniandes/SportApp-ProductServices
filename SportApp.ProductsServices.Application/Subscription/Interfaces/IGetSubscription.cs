namespace SportApp.ProductsServices.Application.Subscription.Interfaces ;
using Domain.Subscription;

    public interface IGetSubscription
    {
        ValueTask<Subscription> ExecuteAsync(GetSubscriptionQuery request);
    }
