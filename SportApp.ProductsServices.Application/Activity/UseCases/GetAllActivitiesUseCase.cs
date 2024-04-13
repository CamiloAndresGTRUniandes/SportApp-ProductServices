namespace SportApp.ProductsServices.Application.Activity.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.Activities;
using Domain.Activities.Queries;
using Domain.Activities.Repositories;
using Interfaces;

    public class GetAllActivitiesUseCase([NotNull] IActivityRepository activityRepository) : IGetAllActivities
    {
        public async ValueTask<ICollection<Activity>> ExecuteAsync(GetAllActivitiesQuery request)
        {
            return await activityRepository.GetAllActiveAsync();
        }
    }
