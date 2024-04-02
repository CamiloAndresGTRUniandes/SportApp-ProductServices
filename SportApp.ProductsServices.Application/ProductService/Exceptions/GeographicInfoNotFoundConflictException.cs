namespace SportApp.ProductsServices.Application.ProductService.Exceptions ;
using Domain.Common.Exceptions;

    public class GeographicInfoNotFoundConflictException(Guid id) : BusinessException($"Geographic info {id} not found")
    {
    }
