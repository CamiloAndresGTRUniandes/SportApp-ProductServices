namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService;
using Domain.ProductService.Queries;
using Interfaces;

    public class GetPlanByIdQueryHandler([NotNull] IGetPlanById getPlanById) : IDomainRequestHandler<GetPlanByIdQuery, Plan>
    {
        public async Task<Plan> Handle(GetPlanByIdQuery request, CancellationToken cancellationToken)
        {
            return await getPlanById.ExecuteAsync(request);
        }
    }
