namespace SportApp.ProductsServices.Domain.ProductService.Queries ;
using Common.Commands;

    public class GetProductServiceQuery : IDomainRequest<ProductService>
    {
        public Guid Id { get; set; }
    }
