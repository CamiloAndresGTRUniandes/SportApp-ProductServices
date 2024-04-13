namespace SportApp.ProductsServices.Domain.ProductService.Queries ;
using Common.Commands;
using GeographicInfo;

    public class GetStatesByCountryQuery : IDomainRequest<ICollection<State>>
    {
        public Guid CountryId { get; set; }
    }
