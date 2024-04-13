namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService;
using Domain.ProductService.Queries;

    public class GetServiceTypeByIdQueryHandler([NotNull] IGetServiceTypeById getServiceTypeById) :
        IDomainRequestHandler<GetServiceTypeByIdQuery, ServiceType>
    {
        public async Task<ServiceType?> Handle(GetServiceTypeByIdQuery request, CancellationToken cancellationToken)
        {
            return await getServiceTypeById.ExecuteAsync(request);
        }
    }
