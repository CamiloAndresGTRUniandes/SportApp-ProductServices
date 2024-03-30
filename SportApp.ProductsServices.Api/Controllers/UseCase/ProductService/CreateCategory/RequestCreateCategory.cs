namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.CreateCategory ;

    public class RequestCreateCategory
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid User { get; set; }
    }
