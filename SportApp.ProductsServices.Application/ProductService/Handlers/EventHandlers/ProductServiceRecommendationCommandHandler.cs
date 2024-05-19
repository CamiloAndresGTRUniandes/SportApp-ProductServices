namespace SportApp.ProductsServices.Application.ProductService.Handlers.EventHandlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Bus;
using Domain.ProductService.Events;
using Recommendation.Interfaces;

    public class ProductServiceRecommendationCommandHandler([NotNull] IProcessProductServiceRecommendation processProductServiceRecommendationCommand) : IEventHandler<ProductServiceRecommendationCommand>
    {
        public async Task Handle(ProductServiceRecommendationCommand @event)
        {
            await processProductServiceRecommendationCommand.ExecuteAsync(@event);
        }
    }
