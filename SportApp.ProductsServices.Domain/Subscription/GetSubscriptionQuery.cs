namespace SportApp.ProductsServices.Domain.Subscription ;
using Common.Commands;

    public class GetSubscriptionQuery : IDomainRequest<Subscription>
    {
        public Guid UserId { get; set; }
    }
