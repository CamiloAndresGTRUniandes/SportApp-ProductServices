namespace SportApp.ProductsServices.Domain.ProductService.Queries ;
using Allergies;
using Common.Commands;

    public class GetAllNutritionalAllergiesQuery : IDomainRequest<ICollection<NutritionalAllergy>>
    {
    }
