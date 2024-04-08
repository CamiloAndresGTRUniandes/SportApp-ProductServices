namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.Allergies;
using Domain.Allergies.Repositories;
using Domain.ProductService.Queries;
using Interfaces;

    public class GetAllNutritionalAllergiesUseCase([NotNull] INutritionalAllergyRepository nutritionalAllergyRepository) : IGetAllNutritionalAllergies
    {
        public async ValueTask<ICollection<NutritionalAllergy>> ExecuteAsync(GetAllNutritionalAllergiesQuery request)
        {
            return await nutritionalAllergyRepository.GetAllActiveAsync();
        }
    }
