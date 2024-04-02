namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.CreateServiceType ;
using System.ComponentModel.DataAnnotations;

    public class RequestCreateServiceType
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public Guid User { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        [Required]
        public Uri Picture { get; set; }
    }
