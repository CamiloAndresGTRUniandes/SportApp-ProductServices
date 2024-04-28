namespace SportApp.ProductsServices.Application.Subscription.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.Subscription;
using Domain.Subscription.Commands;
using Interfaces;

    public class CreateSubscriptionCommandHandler([NotNull] ICreateSubscription createSubscription) :
        IDomainRequestHandler<CreateSubscriptionCommand, Subscription>
    {
        public async Task<Subscription> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
        {
            return await createSubscription.ExecuteAsync(request);
        }
    }
