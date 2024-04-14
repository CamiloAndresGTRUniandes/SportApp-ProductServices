namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService;
using Domain.ProductService.Queries;
using Interfaces;

    public class GetAllPlansQueryHandler([NotNull] IGetAllPlans getAllPlans) : IDomainRequestHandler<GetAllPlansQuery, ICollection<Plan>>
    {
        public async Task<ICollection<Plan>> Handle(GetAllPlansQuery request, CancellationToken cancellationToken)
        {
            return await getAllPlans.ExecuteAsync(request);
        }
    }
