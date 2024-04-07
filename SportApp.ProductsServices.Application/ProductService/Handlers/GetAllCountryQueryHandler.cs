namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService.GeographicInfo;
using Domain.ProductService.Queries;
using Interfaces;

    public class GetAllCountryQueryHandler([NotNull] IGetAllCountries getAllCountries) :
        IDomainRequestHandler<GetAllCountryQuery, ICollection<Country>>
    {
        public async Task<ICollection<Country>> Handle(GetAllCountryQuery request, CancellationToken cancellationToken)
        {
            var countries = await getAllCountries.ExecuteAsync(request);
            return countries;
        }
    }
