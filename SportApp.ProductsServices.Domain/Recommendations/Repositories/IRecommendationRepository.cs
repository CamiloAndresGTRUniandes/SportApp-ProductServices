namespace SportApp.ProductsServices.Domain.Recommendations.Repositories ;

    public interface IRecommendationRepository
    {
        Task SaveAndPublishAsync(Recommendation recommendation);
        Task<ICollection<Recommendation>> GetAllActiveAsync();
    }
