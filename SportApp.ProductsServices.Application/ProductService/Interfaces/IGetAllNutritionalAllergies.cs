namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.Allergies;
using Domain.ProductService.Queries;

    public interface IGetAllNutritionalAllergies
    {
        ValueTask<ICollection<NutritionalAllergy>> ExecuteAsync(GetAllNutritionalAllergiesQuery request);
    }
