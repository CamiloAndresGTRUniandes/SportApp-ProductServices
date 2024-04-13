namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService;
using Domain.ProductService.Commands;

    public interface ICreateServiceType
    {
        ValueTask<ServiceType> ExecuteAsync(CreateServiceTypeCommand request);
    }
