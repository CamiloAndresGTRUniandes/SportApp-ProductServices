namespace SportApp.ProductsServices.Api.Controllers.UseCase.Subscription.CreateSubscription ;
using Domain.Subscription;
using ProductService.GetGeographicComplementary;

    public class SubscriptionResponse
    {
        public Guid SubscriptionId { get; init; }
        public Guid UserId { get; init; }
        public ResponseGetAllReferential Plan { get; init; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public static SubscriptionResponse Build(Subscription subscription)
        {
            return new SubscriptionResponse
            {
                SubscriptionId = subscription.Id,
                UserId = subscription.User,
                Plan = new ResponseGetAllReferential
                {
                    Id = subscription.Plan.Id,
                    Name = subscription.Plan.Name,
                    Price = (long)subscription.Plan.Price
                },
                StartDate = subscription.StartDate.Date,
                EndDate = subscription.EndDate.Date
            };
        }
    }
