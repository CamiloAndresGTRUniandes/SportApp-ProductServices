namespace SportApp.ProductsServices.Api.Controllers.UseCase.Subscription.CreateSubscription ;

    public class RequestCreateSubscription
    {
        public DateTime StartDate { get; set; }
        public Guid User { get; set; }
        public Guid PlanId { get; set; }
    }
