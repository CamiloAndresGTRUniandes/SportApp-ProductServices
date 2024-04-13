namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService.GeographicInfo;
using Domain.ProductService.Queries;

    public interface IGetStatesByCountry
    {
        ValueTask<ICollection<State>> ExecuteAsync(GetStatesByCountryQuery request);
    }
