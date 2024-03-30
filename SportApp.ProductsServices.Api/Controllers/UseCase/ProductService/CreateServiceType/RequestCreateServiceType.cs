namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.CreateServiceType ;

    public class RequestCreateServiceType
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid User { get; set; }
        public Guid CategoryId { get; set; }
        public Uri Picture { get; set; }
    }
