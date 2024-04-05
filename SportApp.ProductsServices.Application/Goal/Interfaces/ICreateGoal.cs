namespace SportApp.ProductsServices.Application.Goal.Interfaces ;
using Domain.Goals;
using Domain.Goals.Commands;

    public interface ICreateGoal
    {
        ValueTask<Goal> ExecuteAsync(CreateGoalCommand request);
    }
