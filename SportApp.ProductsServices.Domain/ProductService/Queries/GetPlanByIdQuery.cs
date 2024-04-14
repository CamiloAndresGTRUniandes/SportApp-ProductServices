namespace SportApp.ProductsServices.Domain.ProductService.Queries ;
using Common.Commands;

    public class GetPlanByIdQuery : IDomainRequest<Plan>
    {
        public Guid Id { get; set; }
    }
