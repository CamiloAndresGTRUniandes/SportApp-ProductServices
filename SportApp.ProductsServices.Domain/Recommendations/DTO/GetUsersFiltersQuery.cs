namespace SportApp.ProductsServices.Domain.Recommendations.DTO ;

    public class GetUsersFiltersQuery
    {
        public List<Guid> CitiesId { get; set; } = new();
        public List<Guid>? StatesId { get; set; } = new();
        public List<Guid>? CountriesId { get; set; } = new();
        public List<Guid>? PhysicalLevels { get; set; } = new();
        public List<Guid>? NutritionalAllergies { get; set; } = new();
        public List<Guid>? Activities { get; set; } = new();
        public List<Guid>? Goals { get; set; } = new();
    }
