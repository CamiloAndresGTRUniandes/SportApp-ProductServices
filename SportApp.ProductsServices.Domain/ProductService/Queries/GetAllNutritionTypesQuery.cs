namespace SportApp.ProductsServices.Domain.ProductService.Queries ;
using Common.Commands;

    public class GetAllNutritionTypesQuery : IDomainRequest<ICollection<TypeOfNutrition>>
    {
    }
