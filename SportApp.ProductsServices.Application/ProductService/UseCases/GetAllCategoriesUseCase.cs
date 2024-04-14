namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Queries;
using Domain.ProductService.Repositories;
using Interfaces;

    public class GetAllCategoriesUseCase([NotNull] ICategoryRepository categoryRepository) : IGetAllCategories
    {
        public async ValueTask<ICollection<Category>> ExecuteAsync(GetAllCategoriesQuery request)
        {
            return await categoryRepository.GetAllActiveAsync();
        }
    }
