namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService.GeographicInfo;
using Domain.ProductService.Queries;
using Domain.ProductService.Repositories;
using Interfaces;

    public class GetAllCountries([NotNull] ICountryRepository countryRepository) : IGetAllCountries
    {
        public async ValueTask<ICollection<Country>> ExecuteAsync(GetAllCountryQuery request)
        {
            var countries = await countryRepository.GetAllActiveAsync();
            return countries;
        }
    }
