namespace SportApp.ProductsServices.Application.ProductService.Exceptions ;
using Domain.Common.Exceptions;

    public class CategoryNotFoundConflictException(Guid categoryId) : BusinessException($"Category not found: {categoryId}")
    {
    }
