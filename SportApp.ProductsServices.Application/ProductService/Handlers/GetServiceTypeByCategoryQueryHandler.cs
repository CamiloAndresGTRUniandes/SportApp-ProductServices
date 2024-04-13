namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService;
using Domain.ProductService.Queries;
using Interfaces;

    public class GetServiceTypeByCategoryQueryHandler([NotNull] IGetServiceTypesByCategory getServiceTypesByCategory) :
        IDomainRequestHandler<GetServiceTypeByCategoryQuery, ICollection<ServiceType>>
    {
        public async Task<ICollection<ServiceType>> Handle(GetServiceTypeByCategoryQuery request, CancellationToken cancellationToken)
        {
            return await getServiceTypesByCategory.ExecuteAsync(request);
        }
    }
