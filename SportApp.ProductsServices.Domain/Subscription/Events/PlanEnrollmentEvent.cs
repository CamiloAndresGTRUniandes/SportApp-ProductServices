namespace SportApp.ProductsServices.Domain.Subscription.Events ;
using Common.Constants;
using Domain.Common.Events;

    public class PlanEnrollmentEvent : Event
    {
        public PlanEnrollmentEvent()
        {
            Queue = Queues.PlanEnrolledQueue;
        }
    public Guid SubscriptionId { get; set; }
        public Guid UserId { get; set; }
        public PlanDto Plan { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public record PlanDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
    }
