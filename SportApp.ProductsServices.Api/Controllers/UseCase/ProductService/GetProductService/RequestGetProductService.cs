namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.GetProductService ;

    public class RequestGetProductService
    {
        public Guid? Id { get; set; }
        public Guid User { get; set; }
        public ICollection<Guid> ServiceTypes { get; set; } = new List<Guid>();
        public ICollection<Guid> Activities { get; set; } = new List<Guid>();
        public ICollection<Guid> Goals { get; set; } = new List<Guid>();
        public ICollection<Guid> TypesOfNutrition { get; set; } = new List<Guid>();
        public ICollection<Guid> Plans { get; set; } = new List<Guid>();
        public ICollection<Guid> GeographicInfoIds { get; set; } = new List<Guid>();
        public ICollection<Guid> Allergies { get; set; } = new List<Guid>();
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
    }
