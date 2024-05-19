namespace SportApp.ProductsServices.Application.Recommendation.Interfaces ;
using Domain.ProductService.Events;

    public interface IProcessProductServiceRecommendation
    {
        ValueTask ExecuteAsync(ProductServiceRecommendationCommand @event);
    }
