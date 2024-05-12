namespace SportApp.ProductsServices.Application.Subscription.UseCases ;
using Domain.Subscription;
using Domain.Subscription.Repositories;
using Interfaces;

    public class GetSubscriptionUseCase(ISubscriptionRepository subscriptionRepository) : IGetSubscription
    {
        public async ValueTask<Subscription> ExecuteAsync(GetSubscriptionQuery request)
        {
            return await subscriptionRepository.GetActiveByUserIdAsync(request.UserId, DateTime.Today, DateTime.Today);
        }
    }
