namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.CreateProductService ;
using System.ComponentModel.DataAnnotations;

    public class RequestCreateProductService
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public long? Price { get; set; }
        public Uri Picture { get; set; }

        [Required]
        public Guid User { get; set; }

        [Required]
        public Guid CountryId { get; set; }

        [Required]
        public Guid StateId { get; set; }

        [Required]
        public Guid CityId { get; set; }

        public Guid? PlanId { get; set; }
        public Guid? TypeOfNutritionId { get; set; }
        public int SportLevel { get; set; }

        [Required]
        public Guid ServiceTypeId { get; set; }

        public ICollection<Guid>? Activities { get; set; } = new List<Guid>();
        public ICollection<Guid>? Goals { get; set; } = new List<Guid>();
        public ICollection<Guid>? NutritionalAllergies { get; set; } = new List<Guid>();
    }
