namespace SportApp.ProductsServices.Application.ProductService.Handlers.EventHandlers ;
using Domain.Common.Bus;
using Domain.ProductService.Events;

    public class ProductServiceRecommendationCommandHandler : IEventHandler<ProductServiceRecommendationCommand>
    {
        public async Task Handle(ProductServiceRecommendationCommand @event)
        {
            throw new NotImplementedException();
        }
    }
