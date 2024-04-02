namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Domain.ProductService.Repositories;
using Exceptions;
using Interfaces;

    public class CreateProductServiceUseCase(
        [NotNull] IProductServiceRepository productServiceRepository,
        [NotNull] IPlanRepository planRepository) : ICreateProductService
    {
        public async ValueTask<ProductService> ExecuteAsync(CreateProductServiceCommand request)
        {
            Plan? plan = null;
            if (request.PlanId.HasValue)
            {
                plan = await planRepository.GetByIdAsync(request.PlanId.Value);
                if (plan == null)
                {
                    throw new PlanNotFoundConflictException(request.PlanId.Value);
                }
            }
            var productService = ProductService.Build(request.Id, request.Name, request.Description, request.Price, request.Picture, null, plan, null,
                null, request.User);

            await productServiceRepository.SaveAndPublishAsync(productService);
            return productService;
        }
    }
