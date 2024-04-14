namespace SportApp.ProductsServices.Application.ProductService.Exceptions ;
using Domain.Common.Exceptions;

    public class ProductServiceNotFoundConflictException(Guid id) : BusinessException($"Product or service {id} not found")
    {
    }
