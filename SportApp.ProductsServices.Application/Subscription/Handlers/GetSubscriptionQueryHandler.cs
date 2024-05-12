namespace SportApp.ProductsServices.Application.Subscription.Handlers ;
using Domain.Common.Commands;
using Domain.Subscription;
using Interfaces;

    public class GetSubscriptionQueryHandler(IGetSubscription getSubscription) : IDomainRequestHandler<GetSubscriptionQuery, Subscription>
    {
        public async Task<Subscription> Handle(GetSubscriptionQuery request, CancellationToken cancellationToken)
        {
            return await getSubscription.ExecuteAsync(request);
        }
    }
