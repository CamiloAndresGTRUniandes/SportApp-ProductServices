namespace SportApp.ProductsServices.Domain.ProductService.Commands ;
using Common.Commands;

    public class GetProductServiceCommand : IDomainRequest<ICollection<ProductService>>
    {
        public Guid? Id { get; set; }
        public Guid User { get; set; }
        public ICollection<Guid> ServiceTypes { get; set; }
        public ICollection<Guid> Categories { get; set; }
        public ICollection<Guid> Activities { get; set; }
        public ICollection<Guid> Goals { get; set; }
        public ICollection<Guid> TypesOfNutrition { get; set; }
        public ICollection<Guid> Plans { get; set; }
        public ICollection<Guid> GeographicInfoIds { get; set; }
        public ICollection<Guid> Allergies { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
    }
