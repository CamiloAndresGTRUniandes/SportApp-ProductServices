namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService.GeographicInfo;
using Domain.ProductService.Queries;

    public interface IGetCitiesByState
    {
        ValueTask<ICollection<City>> ExecuteAsync(GetCitiesByStateQuery request);
    }
