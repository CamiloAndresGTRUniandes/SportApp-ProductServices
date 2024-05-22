namespace SportApp.ProductsServices.Application.ProductService.Handlers.EventHandlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Bus;
using Recommendation.Events;
using Recommendation.Interfaces;

    public class UserProfileEventHandler([NotNull] IProcessUserProfileEvent processUserProfileEvent) : IEventHandler<UserProfileEventBus>
    {
        public async Task Handle(UserProfileEventBus @event)
        {
            await processUserProfileEvent.ExecuteAsync(@event);
        }
    }
