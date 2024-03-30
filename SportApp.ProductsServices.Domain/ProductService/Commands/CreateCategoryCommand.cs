namespace SportApp.ProductsServices.Domain.ProductService.Commands ;
using Common.Commands;
using ValueObjects;

    public class CreateCategoryCommand : IDomainRequest<Category>
    {
        public Guid Id { get; set; }
        public Name Name { get; set; }
        public Description Description { get; set; }
        public Guid User { get; set; }
    }
