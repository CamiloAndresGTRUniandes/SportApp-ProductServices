namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Domain.ProductService.Repositories;
using Exceptions;
using Interfaces;

    public class CreateCategoryUseCase(
        [NotNull] ICategoryRepository categoryRepository
        ) : ICreateCategory
    {
        public async ValueTask<Category> ExecuteAsync(CreateCategoryCommand request)
        {
            var category = await categoryRepository.GetByNameAsync(request.Name);

            if (category is not null)
            {
                throw new CategoryAlreadyExistConflictException(category.Name);
            }
            category = Category.Build(request.Id, request.Name, request.Description, request.User);
            await categoryRepository.SaveAndPublishAsync(category);
            return category;
        }
    }
