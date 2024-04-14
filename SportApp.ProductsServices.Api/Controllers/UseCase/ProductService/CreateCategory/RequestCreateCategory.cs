namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.CreateCategory ;
using System.ComponentModel.DataAnnotations;

    public class RequestCreateCategory
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public Guid User { get; set; }
    }
