namespace SportApp.ProductsServices.Api.Controllers.UseCase.Activity.CreateActivity ;
using System.ComponentModel.DataAnnotations;

    public class RequestCreateActivity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Guid User { get; set; }
    }
