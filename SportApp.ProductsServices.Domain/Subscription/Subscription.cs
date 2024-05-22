namespace SportApp.ProductsServices.Domain.Subscription ;
using Common;
using Events;
using ProductService;

    public class Subscription : BaseDomainModel
    {
        protected Subscription()
        {
        }

        private Subscription(
            Guid id,
            DateTime startDate,
            DateTime endDate,
            Guid user,
            Plan plan)
        {
            Id = id;
            StartDate = startDate;
            EndDate = endDate;
            User = user;
            Plan = plan;
            CreatedBy = user;
            UpdatedBy = user;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid User { get; set; }
        public Plan Plan { get; set; }

        public static Subscription Build(Guid id,
            DateTime startDate,
            DateTime endDate,
            Guid user,
            Plan plan)
        {
            var subscription = new Subscription(id, startDate, endDate, user, plan);
            subscription.SetAdded();
            subscription.RaisePlanEnrollmentEvent();
            return subscription;
        }

        private void RaisePlanEnrollmentEvent()
        {
            var @event = new PlanEnrollmentEvent
            {
                SubscriptionId = Id,
                StartDate = StartDate,
                EndDate = EndDate,
                UserId = CreatedBy!.Value,
                Plan = new PlanDto
                {
                    Id = Plan.Id,
                    Name = Plan.Name.ToString(),
                    Price = (long)Plan.Price
                }
            };
            RaiseDomainEvent(@event);
        }
    }
