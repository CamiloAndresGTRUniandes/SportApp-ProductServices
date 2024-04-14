namespace SportApp.ProductsServices.Application.ProductService.Exceptions ;
using Domain.Common.Exceptions;

    public class TypeOfNutritionAlreadyExistConflictException(string name) : BusinessException($"Type of nutrition {name}, already exist")
    {
    }
