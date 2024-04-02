namespace SportApp.ProductsServices.Domain.ProductService.Repositories ;
using Common.ValueObjects;

    public interface ICategoryRepository
    {
        Task SaveAndPublishAsync(Category category);
        Task<Category?> GetByIdAsync(Guid id);
        Task<Category?> GetByNameAsync(Name name);
    }
