namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Domain.ProductService.Repositories;
using Interfaces;

    public class GetServiceTypesUseCase([NotNull] IServiceTypeRepository serviceTypeRepository) : IGetServiceTypes
    {
        public async ValueTask<ICollection<ServiceType>> ExecuteAsync(GetServiceTypesCommand request)
        {
            var serviceTypes = await serviceTypeRepository.GetAllActiveAsync();
            return serviceTypes;
        }
    }
