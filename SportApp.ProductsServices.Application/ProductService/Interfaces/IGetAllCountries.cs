namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService.GeographicInfo;
using Domain.ProductService.Queries;

    public interface IGetAllCountries
    {
        ValueTask<ICollection<Country>> ExecuteAsync(GetAllCountryQuery request);
    }
