namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService.GeographicInfo;
using Domain.ProductService.Queries;
using Interfaces;

    public class GetCitiesByStateQueryHandler([NotNull] IGetCitiesByState getCitiesByState) :
        IDomainRequestHandler<GetCitiesByStateQuery, ICollection<City>>
    {
        public async Task<ICollection<City>> Handle(GetCitiesByStateQuery request, CancellationToken cancellationToken)
        {
            var cities = await getCitiesByState.ExecuteAsync(request);
            return cities;
        }
    }
