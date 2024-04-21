namespace SportApp.ProductsServices.Application.Goal.Interfaces ;
using Domain.Goals;
using Domain.Goals.Queries;

    public interface IGetGoalById
    {
        ValueTask<Goal?> ExecuteAsync(GetGoalByIdQuery request);
    }
