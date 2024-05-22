namespace SportApp.ProductsServices.Application.Recommendation.Events;
using Domain.Common.Constants;
using Domain.Common.Events;

public class EventsUsersEventBus : Event
    {
        public EventsUsersEventBus()
        {
            Queue = Queues.UserRecommendationsQueue;
        }

        public string Title { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
    }
