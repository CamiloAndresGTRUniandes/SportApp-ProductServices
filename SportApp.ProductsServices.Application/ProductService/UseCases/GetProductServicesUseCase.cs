namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Domain.ProductService.Repositories;
using Interfaces;

    public class GetProductServicesUseCase([NotNull] IProductServiceRepository productServiceRepository) : IGetProductServices
    {
        public async ValueTask<ICollection<ProductService>> ExecuteAsync(GetProductServiceCommand request)
        {
            return await productServiceRepository.GetAllWithParametersAsync(request);
        }
    }
