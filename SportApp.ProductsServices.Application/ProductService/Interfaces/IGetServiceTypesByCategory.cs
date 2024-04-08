namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService;
using Domain.ProductService.Queries;

    public interface IGetServiceTypesByCategory
    {
        ValueTask<ICollection<ServiceType>> ExecuteAsync(GetServiceTypeByCategoryQuery request);
    }
