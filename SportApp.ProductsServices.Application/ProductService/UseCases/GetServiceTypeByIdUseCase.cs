namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Queries;
using Domain.ProductService.Repositories;
using Interfaces;

    public class GetServiceTypeByIdUseCase([NotNull] IServiceTypeRepository serviceTypeRepository) : IGetServiceTypeById
    {
        public async ValueTask<ServiceType?> ExecuteAsync(GetServiceTypeByIdQuery request)
        {
            return await serviceTypeRepository.GetByIdAsync(request.Id);
        }
    }
