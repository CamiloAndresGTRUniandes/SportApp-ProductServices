namespace SportApp.ProductsServices.Application.ProductService.Exceptions ;
using Domain.Common.Exceptions;

    public class PlanNotFoundConflictException(Guid planId) : BusinessException($"Plan not found: {planId}")
    {
    }
