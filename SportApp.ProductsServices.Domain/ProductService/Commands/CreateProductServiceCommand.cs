namespace SportApp.ProductsServices.Domain.ProductService.Commands ;

using Common.Commands;
using ValueObjects;

    public class CreateProductServiceCommand : IDomainRequest<ProductService>
    {
        public Guid Id { get; set; }
        public Name Name { get; set; }
        public Description Description { get; set; }
        public Price Price { get; set; }
        public Uri Picture { get; set; }
        public Guid User { get; set; }
        public Guid GeographicInfoId { get; set; }
        public Guid? PlanId { get; set; }
        public Guid? TypeOfNutritionId { get; set; }
        public Guid ServiceTypeId { get; set; }
    }
