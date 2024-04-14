namespace SportApp.ProductsServices.Domain.ProductService.Commands ;
using Common.Commands;
using Common.ValueObjects;
using ValueObjects;

    public class CreatePlanCommand : IDomainRequest<Plan>
    {
        public Guid Id { get; set; }
        public Name Name { get; set; }
        public Description Description { get; set; }
        public Price Price { get; set; }
        public Guid User { get; set; }
    }
