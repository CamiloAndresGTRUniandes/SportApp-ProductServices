namespace SportApp.ProductsServices.Domain.ProductService.Queries ;
using Common.Commands;

    public class GetServiceTypeByIdQuery : IDomainRequest<ServiceType>
    {
        public Guid Id { get; set; }
    }
