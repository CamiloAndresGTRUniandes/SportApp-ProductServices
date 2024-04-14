namespace SportApp.ProductsServices.Application.Activity.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Activities;
using Domain.Activities.Commands;
using Domain.Common.Commands;
using Interfaces;

    public class CreateActivityCommandHandler([NotNull] ICreateActivity createActivity) : IDomainRequestHandler<CreateActivityCommand, Activity>
    {
        public async Task<Activity> Handle(CreateActivityCommand request, CancellationToken cancellationToken)
        {
            return await createActivity.ExecuteAsync(request);
        }
    }
