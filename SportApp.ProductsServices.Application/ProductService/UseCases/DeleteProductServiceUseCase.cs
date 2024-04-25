namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Domain.ProductService.Repositories;
using Interfaces;

    public class DeleteProductServiceUseCase([NotNull] IProductServiceRepository productServiceRepository) : IDeleteProductService
    {
        public async Task<ProductService> ExecuteAsync(DeleteProductServiceCommand request)
        {
            var productService = await productServiceRepository.GetByIdAsync(request.Id);
            if (productService != null)
            {
                productService.Disable();
                productServiceRepository.SaveAndPublishAsync(productService);
            }
            return productService;
        }
    }
