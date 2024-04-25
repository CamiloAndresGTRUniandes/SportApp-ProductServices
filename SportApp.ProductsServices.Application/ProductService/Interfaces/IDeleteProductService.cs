namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService;
using Domain.ProductService.Commands;

    public interface IDeleteProductService
    {
        Task<ProductService> ExecuteAsync(DeleteProductServiceCommand request);
    }
