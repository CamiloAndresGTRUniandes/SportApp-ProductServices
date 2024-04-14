namespace SportApp.ProductsServices.Domain.ProductService.Queries ;
using Common.Commands;

    public class GetServiceTypeByCategoryQuery : IDomainRequest<ICollection<ServiceType>>
    {
        public Guid CategoryId { get; set; }
    }
