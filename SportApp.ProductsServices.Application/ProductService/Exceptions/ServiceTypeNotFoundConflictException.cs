namespace SportApp.ProductsServices.Application.ProductService.Exceptions ;
using Domain.Common.Exceptions;

    public class ServiceTypeNotFoundConflictException(Guid id) : BusinessException($"Service type {id} not found")
    {
    }
