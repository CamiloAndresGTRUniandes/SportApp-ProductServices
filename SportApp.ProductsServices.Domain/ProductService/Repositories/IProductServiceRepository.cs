namespace SportApp.ProductsServices.Domain.ProductService.Repositories ;

    public interface IProductServiceRepository
    {
        Task SaveAndPublishAsync(ProductService productService);
        Task<ProductService?> GetByIdAsync(Guid id);
        Task<ICollection<ProductService>> GetAllActiveAsync();
    }
