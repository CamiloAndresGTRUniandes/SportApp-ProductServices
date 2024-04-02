namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Domain.ProductService.Repositories;
using Interfaces;

    public class CreateGeographicInfoUseCase([NotNull] IGeographicInfoRepository geographicInfoRepository) : ICreateGeographicInfo
    {
        public async ValueTask<GeographicInfo> ExecuteAsync(CreateGeographicInfoCommand request)
        {
            var geographicInfo = await geographicInfoRepository.GetByIdAsync(request.Id);
            if (geographicInfo is null)
            {
                geographicInfo = GeographicInfo.Build(request.Id, request.CountryId, request.StateId, request.CityId, request.UserId);
                await geographicInfoRepository.SaveAndPublishAsync(geographicInfo);
            }
            return geographicInfo;
        }
    }
