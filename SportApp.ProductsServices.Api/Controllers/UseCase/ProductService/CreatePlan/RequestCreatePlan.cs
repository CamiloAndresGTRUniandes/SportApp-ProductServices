namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.CreatePlan ;
using System.ComponentModel.DataAnnotations;

    public class RequestCreatePlan
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public Guid User { get; set; }

        [Required]
        public long Price { get; set; }
    }
