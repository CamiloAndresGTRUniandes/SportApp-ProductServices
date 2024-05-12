namespace SportApp.ProductsServices.Application.ProductService.Handlers.EventHandlers ;
using Domain.Common.Bus;
using Events;

    public class UserProfileEventHandler : IEventHandler<UserProfileEventBus>
    {
        public async Task Handle(UserProfileEventBus @event)
        {
            throw new NotImplementedException();
        }
    }
