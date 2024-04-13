namespace SportApp.ProductsServices.Domain.ProductService.Repositories ;
using GeographicInfo;

    public interface IStateRepository
    {
        Task SaveAndPublishAsync(State state);
        Task<Country?> GetAllActiveByCountryAsync(Guid id);
        Task<State?> GetAllActiveCityByStateAsync(Guid id);
    }
