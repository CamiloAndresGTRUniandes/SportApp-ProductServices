namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService.GeographicInfo;
using Domain.ProductService.Queries;
using Domain.ProductService.Repositories;
using Interfaces;

    public class GetStatesByCountryUseCase([NotNull] IStateRepository stateRepository) : IGetStatesByCountry
    {
        public async ValueTask<ICollection<State>> ExecuteAsync(GetStatesByCountryQuery request)
        {
            var states = new List<State>();
            var country = await stateRepository.GetAllActiveByCountryAsync(request.CountryId);
            if (country != null)
            {
                states.AddRange([.. country.State]);
            }
            return states;
        }
    }
