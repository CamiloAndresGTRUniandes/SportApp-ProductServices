namespace SportApp.ProductsServices.Api.Controllers.UseCase.Goal.CreateGoal ;
using System.ComponentModel.DataAnnotations;

    public class RequestCreateGoal
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Guid User { get; set; }
    }
