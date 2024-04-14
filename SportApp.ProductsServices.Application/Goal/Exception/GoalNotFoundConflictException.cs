namespace SportApp.ProductsServices.Application.Goal.Exception ;
using Domain.Common.Exceptions;

    public class GoalNotFoundConflictException(Guid id) : BusinessException($"Goal {id} not found")
    {
    }
