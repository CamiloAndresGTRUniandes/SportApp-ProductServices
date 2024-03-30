namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Domain.ProductService.Repositories;
using Interfaces;

    public class CreateCategory(
        [NotNull] ICategoryRepository categoryRepository
        ) : ICreateCategory
    {
        public async ValueTask<Category> ExecuteAsync(CreateCategoryCommand request)
        {
            var category = Category.Build(request.Id, request.Name, request.Description, request.User);
            await categoryRepository.SaveAndPublishAsync(category);
            return category;
        }
    }
