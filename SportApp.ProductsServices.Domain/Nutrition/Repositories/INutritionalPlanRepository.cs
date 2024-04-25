namespace SportApp.ProductsServices.Domain.Nutrition.Repositories ;

    public interface INutritionalPlanRepository
    {
        Task SaveAndPublishAsync(NutritionalPlan category);
        Task<NutritionalPlan?> GetByIdAsync(Guid id);
    }
