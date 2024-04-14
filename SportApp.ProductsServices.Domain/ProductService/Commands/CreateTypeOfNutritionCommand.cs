namespace SportApp.ProductsServices.Domain.ProductService.Commands ;
using Common.Commands;
using Common.ValueObjects;

    public class CreateTypeOfNutritionCommand : IDomainRequest<TypeOfNutrition>
    {
        public Guid Id { get; set; }
        public Name Name { get; set; }
        public Guid User { get; set; }
    }
