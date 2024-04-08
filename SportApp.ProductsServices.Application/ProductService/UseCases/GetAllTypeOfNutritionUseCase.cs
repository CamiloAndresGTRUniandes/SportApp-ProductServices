namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Queries;
using Domain.ProductService.Repositories;
using Interfaces;

    public class GetAllTypeOfNutritionUseCase([NotNull] ITypeOfNutritionRepository typeOfNutritionRepository) : IGetAllTypeOfNutrition
    {
        public async ValueTask<ICollection<TypeOfNutrition>> ExecuteAsync(GetAllNutritionTypesQuery request)
        {
            return await typeOfNutritionRepository.GetAllActiveAsync();
        }
    }
