namespace SportApp.ProductsServices.Domain.ProductService.Commands ;
using Common.Commands;
using Common.ValueObjects;
using ValueObjects;

    public class CreateServiceTypeCommand : IDomainRequest<ServiceType>
    {
        public Guid Id { get; set; }
        public Name Name { get; set; }
        public Description Description { get; set; }
        public Uri Picture { get; set; }
        public Guid? User { get; set; }
        public Guid? CategoryId { get; set; }
    }
