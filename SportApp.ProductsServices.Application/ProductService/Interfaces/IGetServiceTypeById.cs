namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService;
using Domain.ProductService.Queries;

    public interface IGetServiceTypeById
    {
        ValueTask<ServiceType?> ExecuteAsync(GetServiceTypeByIdQuery request);
    }
