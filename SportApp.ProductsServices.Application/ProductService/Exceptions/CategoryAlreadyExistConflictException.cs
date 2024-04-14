namespace SportApp.ProductsServices.Application.ProductService.Exceptions ;
using Domain.Common.Exceptions;

    public class CategoryAlreadyExistConflictException(string name) : BusinessException($"Category {name}, already exist")
    {
    }
