namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.CreateGeographicInfo ;

    public class RequestCreateGeographicInfo
    {
        public Guid CountryId { get; set; }
        public Guid StateId { get; set; }
        public Guid CityId { get; set; }
        public Guid UserId { get; set; }
    }
