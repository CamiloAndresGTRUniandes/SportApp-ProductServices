namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService.GeographicInfo;
using Domain.ProductService.Queries;
using Interfaces;

    public class GetStatesByCountryQueryHandler([NotNull] IGetStatesByCountry getStatesByCountry) :
        IDomainRequestHandler<GetStatesByCountryQuery, ICollection<State>>
    {
        public async Task<ICollection<State>> Handle(GetStatesByCountryQuery request, CancellationToken cancellationToken)
        {
            var states = await getStatesByCountry.ExecuteAsync(request);
            return states;
        }
    }
