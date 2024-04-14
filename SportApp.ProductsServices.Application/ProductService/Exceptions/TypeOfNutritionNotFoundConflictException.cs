namespace SportApp.ProductsServices.Application.ProductService.Exceptions ;
using Domain.Common.Exceptions;

    public class TypeOfNutritionNotFoundConflictException(Guid id) : BusinessException($"Type of nutrition {id} not found")
    {
    }
