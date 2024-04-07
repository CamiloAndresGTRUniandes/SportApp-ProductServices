namespace SportApp.ProductsServices.Domain.ProductService.Repositories ;
using GeographicInfo;

    public interface IGeographicInfoRepository
    {
        Task SaveAndPublishAsync(GeographicInfo geographicInfo);
        Task<GeographicInfo?> GetByIdAsync(Guid id);
    }
