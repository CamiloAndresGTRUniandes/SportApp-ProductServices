namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Domain.ProductService.Repositories;
using Exceptions;
using Interfaces;

    public class CreateServiceType(
        [NotNull] IServiceTypeRepository serviceTypeRepository,
        [NotNull] ICategoryRepository categoryRepository) : ICreateServiceType
    {
        public async ValueTask<ServiceType> ExecuteAsync(CreateServiceTypeCommand request)
        {
            Category? category = null;
            if (request.CategoryId.HasValue)
            {
                category = await categoryRepository.GetByIdAsync(request.CategoryId.Value);
                if (category is null)
                {
                    throw new CategoryNotFoundConflictException(request.CategoryId.Value);
                }
            }
            var serviceType = ServiceType.Build(request.Id, request.Name, request.Description, request.Picture, category!, request.User!.Value);
            await serviceTypeRepository.SaveAndPublishAsync(serviceType);
            return serviceType;
        }
    }
