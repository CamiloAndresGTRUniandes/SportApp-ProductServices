namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Interfaces;

    public class CreateServiceTypeCommandHandler([NotNull] ICreateServiceType createServiceType) :
        IDomainRequestHandler<CreateServiceTypeCommand, ServiceType>
    {
        public async Task<ServiceType> Handle(CreateServiceTypeCommand request, CancellationToken cancellationToken)
        {
            var serviceType = await createServiceType.ExecuteAsync(request);
            return serviceType;
        }
    }
