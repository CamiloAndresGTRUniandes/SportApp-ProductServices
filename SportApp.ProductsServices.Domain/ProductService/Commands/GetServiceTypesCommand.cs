namespace SportApp.ProductsServices.Domain.ProductService.Commands ;
using Common.Commands;

    public class GetServiceTypesCommand : IDomainRequest<ICollection<ServiceType>>
    {
        public bool Enabled { get; set; }
    }
