namespace SportApp.ProductsServices.Domain.Recommendations.Repositories ;

    public interface IRecommendationRepository
    {
        Task SaveAndPublishAsync(ICollection<Recommendation> recommendationList);
        Task<ICollection<Recommendation>> GetAllActiveAsync();
    }
