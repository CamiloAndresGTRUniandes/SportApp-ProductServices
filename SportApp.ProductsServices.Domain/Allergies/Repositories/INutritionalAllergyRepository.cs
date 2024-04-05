namespace SportApp.ProductsServices.Domain.Allergies.Repositories ;
using Common.ValueObjects;

    public interface INutritionalAllergyRepository
    {
        Task SaveAndPublishAsync(NutritionalAllergy allergy);
        Task<NutritionalAllergy?> GetByIdAsync(Guid id);
        Task<NutritionalAllergy?> GetByNameAsync(Name name);
    }
