namespace SportApp.ProductsServices.Domain.ProductService.Commands ;
using Common.Commands;

    public class GetProductServiceCommand : IDomainRequest<ICollection<ProductService>>
    {
        public Guid? Id { get; init; }
        public Guid? User { get; init; }
        public ICollection<Guid> ServiceTypes { get; init; } = new List<Guid>();
        public ICollection<Guid> Categories { get; init; } = new List<Guid>();
        public ICollection<Guid> Activities { get; init; } = new List<Guid>();
        public ICollection<Guid> Goals { get; init; } = new List<Guid>();
        public ICollection<Guid> TypesOfNutrition { get; set; } = new List<Guid>();
        public ICollection<Guid> Plans { get; init; } = new List<Guid>();
        public ICollection<Guid> GeographicInfoIds { get; init; } = new List<Guid>();
        public ICollection<Guid> Allergies { get; init; } = new List<Guid>();
        public DateTime? StartDateTime { get; init; }
        public DateTime? EndDateTime { get; init; }
    }
