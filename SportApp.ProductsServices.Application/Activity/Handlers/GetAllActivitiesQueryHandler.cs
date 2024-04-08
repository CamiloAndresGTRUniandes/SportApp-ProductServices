namespace SportApp.ProductsServices.Application.Activity.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Activities;
using Domain.Activities.Queries;
using Domain.Common.Commands;
using Interfaces;

    public class GetAllActivitiesQueryHandler([NotNull] IGetAllActivities getAllActivities) :
        IDomainRequestHandler<GetAllActivitiesQuery, ICollection<Activity>>
    {
        public async Task<ICollection<Activity>> Handle(GetAllActivitiesQuery request, CancellationToken cancellationToken)
        {
            var activities = await getAllActivities.ExecuteAsync(request);
            return activities;
        }
    }
