namespace SportApp.ProductsServices.Domain.ProductService.Queries ;
using Common.Commands;
using GeographicInfo;

    public class GetCitiesByStateQuery : IDomainRequest<ICollection<City>>
    {
        public Guid StateId { get; set; }
    }
