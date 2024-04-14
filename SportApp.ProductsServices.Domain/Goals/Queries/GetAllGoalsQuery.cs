namespace SportApp.ProductsServices.Domain.Goals.Queries ;
using Common.Commands;

    public class GetAllGoalsQuery : IDomainRequest<ICollection<Goal>>
    {
    }
