namespace SportApp.ProductsServices.Domain.ProductService.Queries ;
using Common.Commands;

    public class GetAllCategoriesQuery : IDomainRequest<ICollection<Category>>
    {
    }
