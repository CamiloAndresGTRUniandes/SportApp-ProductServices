namespace SportApp.ProductsServices.Domain.ProductService.Commands ;
using Common.Commands;

    public class DeleteProductServiceCommand : IDomainRequest<ProductService>
    {
        public Guid Id { get; set; }
    }
