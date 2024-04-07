namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService.Commands;
using Domain.ProductService.GeographicInfo;
using Interfaces;

    public class CreateGeographicInfoCommandHandler(
        [NotNull] ICreateGeographicInfo createGeographicInfo) : IDomainRequestHandler<CreateGeographicInfoCommand, GeographicInfo>
    {
        public async Task<GeographicInfo> Handle(CreateGeographicInfoCommand request, CancellationToken cancellationToken)
        {
            var geographicInfo = await createGeographicInfo.ExecuteAsync(request);
            return geographicInfo;
        }
    }
