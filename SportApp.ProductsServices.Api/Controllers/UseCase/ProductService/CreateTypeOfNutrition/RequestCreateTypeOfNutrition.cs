namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.CreateTypeOfNutrition ;
using System.ComponentModel.DataAnnotations;

    public class RequestCreateTypeOfNutrition
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public Guid User { get; set; }
    }
