namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService;
using Domain.ProductService.Commands;

    public interface ICreateTypeOfNutrition
    {
        ValueTask<TypeOfNutrition> ExecuteAsync(CreateTypeOfNutritionCommand request);
    }
