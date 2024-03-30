namespace SportApp.ProductsServices.Domain.ProductService.Repositories ;

    public interface ICategoryRepository
    {
        Task SaveAndPublishAsync(Category category);
        Task<Category?> GetByIdAsync(Guid id);
    }
