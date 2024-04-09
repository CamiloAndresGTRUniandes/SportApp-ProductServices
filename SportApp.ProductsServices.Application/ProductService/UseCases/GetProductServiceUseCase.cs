namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Queries;
using Domain.ProductService.Repositories;
using Exceptions;
using Interfaces;

    public class GetProductServiceUseCase([NotNull] IProductServiceRepository productServiceRepository) : IGetProductService
    {
        public async ValueTask<ProductService> ExecuteAsync(GetProductServiceQuery request)
        {
            var productService = await productServiceRepository.GetByIdAsync(request.Id);
            if (productService is null)
            {
                throw new ProductServiceNotFoundConflictException(request.Id);
            }
            return productService;
        }
    }
