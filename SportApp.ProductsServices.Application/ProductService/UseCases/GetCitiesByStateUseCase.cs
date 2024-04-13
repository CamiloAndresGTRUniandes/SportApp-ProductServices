namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService.GeographicInfo;
using Domain.ProductService.Queries;
using Domain.ProductService.Repositories;
using Interfaces;

    public class GetCitiesByStateUseCase([NotNull] IStateRepository stateRepository) : IGetCitiesByState
    {
        public async ValueTask<ICollection<City>> ExecuteAsync(GetCitiesByStateQuery request)
        {
            var cities = new List<City>();
            var state = await stateRepository.GetAllActiveCityByStateAsync(request.StateId);
            if (state != null)
            {
                cities.AddRange([.. state.City]);
            }
            return cities;
        }
    }
