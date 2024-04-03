namespace SportApp.ProductsServices.Domain.ProductService.Repositories ;
using Commands;

    public interface IProductServiceRepository
    {
        Task SaveAndPublishAsync(ProductService productService);
        Task<ProductService?> GetByIdAsync(Guid id);
        Task<ICollection<ProductService>> GetAllActiveAsync();
        Task<ICollection<ProductService>> GetAllWithParametersAsync(GetProductServiceCommand parameters);
    }
