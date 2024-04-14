namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService;
using Domain.ProductService.Queries;

    public interface IGetProductService
    {
        ValueTask<ProductService> ExecuteAsync(GetProductServiceQuery request);
    }
