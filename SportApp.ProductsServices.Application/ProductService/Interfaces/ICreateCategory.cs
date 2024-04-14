namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService;
using Domain.ProductService.Commands;

    public interface ICreateCategory
    {
        ValueTask<Category> ExecuteAsync(CreateCategoryCommand request);
    }
