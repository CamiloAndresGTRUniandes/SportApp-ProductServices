namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService;
using Domain.ProductService.Commands;

    public interface IGetServiceTypes
    {
        ValueTask<ICollection<ServiceType>> ExecuteAsync(GetServiceTypesCommand request);
    }
