namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService;
using Domain.ProductService.Commands;

    public interface IGetProductServices
    {
        ValueTask<ICollection<ProductService>> ExecuteAsync(GetProductServiceCommand request);
    }
