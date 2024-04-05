namespace SportApp.ProductsServices.Application.Activity.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.Activities;
using Domain.Activities.Commands;
using Domain.Activities.Repositories;
using Interfaces;

    public class CreateActivityUseCase([NotNull] IActivityRepository activityRepository) : ICreateActivity
    {
        public async ValueTask<Activity> ExecuteAsync(CreateActivityCommand request)
        {
            var activity = Activity.Build(request.Id, request.Name, request.User);
            await activityRepository.SaveAndPublishAsync(activity);
            return activity;
        }
    }
