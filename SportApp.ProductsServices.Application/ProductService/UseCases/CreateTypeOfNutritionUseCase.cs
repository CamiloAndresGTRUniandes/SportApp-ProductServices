namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Domain.ProductService.Repositories;
using Exceptions;
using Interfaces;

    public class CreateTypeOfNutritionUseCase([NotNull] ITypeOfNutritionRepository typeOfNutritionRepository) : ICreateTypeOfNutrition
    {
        public async ValueTask<TypeOfNutrition> ExecuteAsync(CreateTypeOfNutritionCommand request)
        {
            var typeOfNutrition = await typeOfNutritionRepository.GetByNameAsync(request.Name);
            if (typeOfNutrition is not null)
            {
                throw new TypeOfNutritionAlreadyExistConflictException(typeOfNutrition.Name);
            }
            typeOfNutrition = TypeOfNutrition.Build(request.Id, request.Name, request.User);
            await typeOfNutritionRepository.SaveAndPublishAsync(typeOfNutrition);
            return typeOfNutrition;
        }
    }
