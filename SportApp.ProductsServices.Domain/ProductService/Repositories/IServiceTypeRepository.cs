namespace SportApp.ProductsServices.Domain.ProductService.Repositories ;

    public interface IServiceTypeRepository
    {
        Task SaveAndPublishAsync(ServiceType serviceType);
        Task<ServiceType?> GetByIdAsync(Guid id);
        Task<ICollection<ServiceType>> GetAllActiveAsync();

        Task<Category?> GetAllActiveServiceTypesByCategoryAsync(Guid id);
    }
