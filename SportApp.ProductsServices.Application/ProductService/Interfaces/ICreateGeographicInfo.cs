namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService.Commands;
using Domain.ProductService.GeographicInfo;

    public interface ICreateGeographicInfo
    {
        ValueTask<GeographicInfo> ExecuteAsync(CreateGeographicInfoCommand request);
    }
