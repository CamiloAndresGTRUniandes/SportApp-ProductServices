namespace SportApp.ProductsServices.Application.Goal.Interfaces ;
using Domain.Goals;
using Domain.Goals.Queries;

    public interface IGetAllGoals
    {
        ValueTask<ICollection<Goal>> ExecuteAsync(GetAllGoalsQuery request);
    }
