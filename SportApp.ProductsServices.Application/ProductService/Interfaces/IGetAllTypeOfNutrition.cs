namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService;
using Domain.ProductService.Queries;

    public interface IGetAllTypeOfNutrition
    {
        ValueTask<ICollection<TypeOfNutrition>> ExecuteAsync(GetAllNutritionTypesQuery request);
    }
