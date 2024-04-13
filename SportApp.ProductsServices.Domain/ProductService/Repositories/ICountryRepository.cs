namespace SportApp.ProductsServices.Domain.ProductService.Repositories ;
using GeographicInfo;

    public interface ICountryRepository
    {
        Task SaveAndPublishAsync(Country country);
        Task<ICollection<Country>> GetAllActiveAsync();
    }
