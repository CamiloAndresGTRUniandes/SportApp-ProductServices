namespace SportApp.ProductsServices.Application.Subscription.Interfaces ;
using Domain.Subscription;
using Domain.Subscription.Commands;

    public interface ICreateSubscription
    {
        ValueTask<Subscription> ExecuteAsync(CreateSubscriptionCommand request);
    }
