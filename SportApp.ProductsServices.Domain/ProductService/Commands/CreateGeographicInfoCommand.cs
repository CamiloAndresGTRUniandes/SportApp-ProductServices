namespace SportApp.ProductsServices.Domain.ProductService.Commands ;
using Common.Commands;
using GeographicInfo;

    public class CreateGeographicInfoCommand : IDomainRequest<GeographicInfo>
    {
        public Guid Id { get; set; }
        public Guid CountryId { get; set; }
        public Guid StateId { get; set; }
        public Guid CityId { get; set; }
        public Guid UserId { get; set; }
    }
