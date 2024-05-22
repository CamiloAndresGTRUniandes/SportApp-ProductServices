namespace SportApp.ProductsServices.Domain.Goals.Queries ;
using Common.Commands;

    public class GetGoalByIdQuery : IDomainRequest<Goal>
    {
        public Guid Id { get; set; }
    }
