namespace SportApp.ProductsServices.Application.Recommendation.Interfaces ;
using Events;

    public interface IProcessUserProfileEvent
    {
        ValueTask ExecuteAsync(UserProfileEventBus @event);
    }
