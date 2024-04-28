namespace SportApp.ProductsServices.Domain.Subscription.Commands ;
using Common.Commands;

    public class CreateSubscriptionCommand : IDomainRequest<Subscription>
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid User { get; set; }
        public Guid PlanId { get; set; }
    }
