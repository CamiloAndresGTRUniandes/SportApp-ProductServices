namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Interfaces;

    public class GetServiceTypesCommandHandler([NotNull] IGetServiceTypes getServiceTypes) :
        IDomainRequestHandler<GetServiceTypesCommand, ICollection<ServiceType>>
    {
        public async Task<ICollection<ServiceType>> Handle(GetServiceTypesCommand request, CancellationToken cancellationToken)
        {
            return await getServiceTypes.ExecuteAsync(request);
        }
    }
