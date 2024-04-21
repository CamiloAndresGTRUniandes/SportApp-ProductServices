namespace SportApp.ProductsServices.Application.Goal.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.Goals;
using Domain.Goals.Queries;
using Interfaces;

    public class GetGoalByIdQueryHandler([NotNull] IGetGoalById getGoalById) : IDomainRequestHandler<GetGoalByIdQuery, Goal>
    {
        public async Task<Goal> Handle(GetGoalByIdQuery request, CancellationToken cancellationToken)
        {
            return await getGoalById.ExecuteAsync(request);
        }
    }
