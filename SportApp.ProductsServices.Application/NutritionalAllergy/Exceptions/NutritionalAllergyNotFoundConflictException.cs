namespace SportApp.ProductsServices.Application.NutritionalAllergy.Exceptions ;
using Domain.Common.Exceptions;

    public class NutritionalAllergyNotFoundConflictException(Guid id) : BusinessException($"Nutritional allergy {id} not found")
    {
    }
