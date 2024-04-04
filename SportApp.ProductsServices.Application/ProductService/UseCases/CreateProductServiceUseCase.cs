namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Domain.ProductService.Repositories;
using Exceptions;
using Interfaces;

    public class CreateProductServiceUseCase(
        [NotNull] IProductServiceRepository productServiceRepository,
        [NotNull] IPlanRepository planRepository,
        [NotNull] ITypeOfNutritionRepository typeOfNutritionRepository,
        [NotNull] IGeographicInfoRepository geographicInfoRepository,
        [NotNull] IServiceTypeRepository serviceTypeRepository) : ICreateProductService
    {
        public async ValueTask<ProductService> ExecuteAsync(CreateProductServiceCommand request)
        {
            Plan? plan = null;
            TypeOfNutrition? typOfNutrition = null;
            if (request.PlanId.HasValue)
            {
                plan = await planRepository.GetByIdAsync(request.PlanId.Value);
                if (plan is null)
                {
                    throw new PlanNotFoundConflictException(request.PlanId.Value);
                }
            }

            if (request.TypeOfNutritionId.HasValue)
            {
                typOfNutrition = await typeOfNutritionRepository.GetByIdAsync(request.TypeOfNutritionId.Value);
                if (typOfNutrition is null)
                {
                    throw new TypeOfNutritionNotFoundConflictException(request.TypeOfNutritionId.Value);
                }
            }

            var geographicInfo = await geographicInfoRepository.GetByIdAsync(request.GeographicInfoId!.Value) ??
                                 throw new GeographicInfoNotFoundConflictException(request.GeographicInfoId!.Value);

            var serviceType = await serviceTypeRepository.GetByIdAsync(request.ServiceTypeId) ??
                              throw new ServiceTypeNotFoundConflictException(request.ServiceTypeId);

            var productService = ProductService.Build(request.Id, request.Name, request.Description, request.Price, request.Picture, geographicInfo,
                plan, typOfNutrition, serviceType, request.SportLevel, request.User, request.StartDateTime, request.EndDateTime);

            await productServiceRepository.SaveAndPublishAsync(productService);
            return productService;
        }
    }
