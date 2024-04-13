namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Queries;
using Domain.ProductService.Repositories;
using Interfaces;

    public class GetServiceTypesByCategoryUseCase([NotNull] IServiceTypeRepository serviceTypeRepository) : IGetServiceTypesByCategory
    {
        public async ValueTask<ICollection<ServiceType>> ExecuteAsync(GetServiceTypeByCategoryQuery request)
        {
            var serviceTypes = new List<ServiceType>();
            var category = await serviceTypeRepository.GetAllActiveServiceTypesByCategoryAsync(request.CategoryId);
            if (category != null)
            {
                serviceTypes.AddRange([.. category.ServiceType]);
            }
            return serviceTypes;
        }
    }
