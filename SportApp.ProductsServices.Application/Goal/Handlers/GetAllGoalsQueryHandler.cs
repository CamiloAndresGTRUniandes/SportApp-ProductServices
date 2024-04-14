namespace SportApp.ProductsServices.Application.Goal.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.Goals;
using Domain.Goals.Queries;
using Interfaces;

    public class GetAllGoalsQueryHandler([NotNull] IGetAllGoals getAllGoals) : IDomainRequestHandler<GetAllGoalsQuery, ICollection<Goal>>
    {
        public async Task<ICollection<Goal>> Handle(GetAllGoalsQuery request, CancellationToken cancellationToken)
        {
            return await getAllGoals.ExecuteAsync(request);
        }
    }
