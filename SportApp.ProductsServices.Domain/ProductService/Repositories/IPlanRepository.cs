namespace SportApp.ProductsServices.Domain.ProductService.Repositories ;

    public interface IPlanRepository
    {
        Task SaveAndPublishAsync(Plan plan);
        Task<Plan?> GetByIdAsync(Guid id);
    }
