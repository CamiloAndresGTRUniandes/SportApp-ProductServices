namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.CreateGeographicInfo ;
using System.ComponentModel.DataAnnotations;

    public class RequestCreateGeographicInfo
    {
        [Required]
        public Guid CountryId { get; set; }

        [Required]
        public Guid StateId { get; set; }

        [Required]
        public Guid CityId { get; set; }

        [Required]
        public Guid UserId { get; set; }
    }
