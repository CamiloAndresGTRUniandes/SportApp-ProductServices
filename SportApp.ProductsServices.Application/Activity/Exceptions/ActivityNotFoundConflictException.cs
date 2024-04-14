namespace SportApp.ProductsServices.Application.Activity.Exceptions ;
using Domain.Common.Exceptions;

    public class ActivityNotFoundConflictException(Guid id) : BusinessException($"Activity {id} not found")
    {
    }
