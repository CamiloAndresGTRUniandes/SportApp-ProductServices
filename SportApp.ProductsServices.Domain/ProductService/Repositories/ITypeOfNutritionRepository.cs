﻿namespace SportApp.ProductsServices.Domain.ProductService.Repositories ;
using Common.ValueObjects;

    public interface ITypeOfNutritionRepository
    {
        Task SaveAndPublishAsync(TypeOfNutrition typeOfNutrition);
        Task<TypeOfNutrition?> GetByIdAsync(Guid id);
        Task<ICollection<TypeOfNutrition>> GetAllActiveAsync();
        Task<TypeOfNutrition?> GetByNameAsync(Name name);
    }
