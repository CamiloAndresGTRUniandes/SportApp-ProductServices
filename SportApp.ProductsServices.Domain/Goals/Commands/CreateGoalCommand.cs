namespace SportApp.ProductsServices.Domain.Goals.Commands ;
using Common.Commands;
using Common.ValueObjects;

    public class CreateGoalCommand : IDomainRequest<Goal>
    {
        public Guid Id { get; set; }
        public Name Name { get; set; }
        public Guid User { get; set; }
    }
