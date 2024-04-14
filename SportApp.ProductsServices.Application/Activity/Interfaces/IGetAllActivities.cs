namespace SportApp.ProductsServices.Application.Activity.Interfaces ;
using Domain.Activities;
using Domain.Activities.Queries;

    public interface IGetAllActivities
    {
        ValueTask<ICollection<Activity>> ExecuteAsync(GetAllActivitiesQuery request);
    }
