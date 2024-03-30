namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService;
using Domain.ProductService.Commands;

    public interface ICreateProductService
    {
        ValueTask<ProductService> ExecuteAsync(CreateProductServiceCommand request);
    }
