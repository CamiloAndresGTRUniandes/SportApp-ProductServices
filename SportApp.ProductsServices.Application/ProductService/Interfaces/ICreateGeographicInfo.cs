namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService;
using Domain.ProductService.Commands;

    public interface ICreateGeographicInfo
    {
        ValueTask<GeographicInfo> ExecuteAsync(CreateGeographicInfoCommand request);
    }
