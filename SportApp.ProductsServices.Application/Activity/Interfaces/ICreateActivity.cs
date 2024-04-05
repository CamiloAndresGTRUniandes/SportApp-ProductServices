namespace SportApp.ProductsServices.Application.Activity.Interfaces ;
using Domain.Activities;
using Domain.Activities.Commands;

    public interface ICreateActivity
    {
        ValueTask<Activity> ExecuteAsync(CreateActivityCommand request);
    }
