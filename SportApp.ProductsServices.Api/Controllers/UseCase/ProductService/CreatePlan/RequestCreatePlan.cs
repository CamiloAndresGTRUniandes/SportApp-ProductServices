namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.CreatePlan ;

    public class RequestCreatePlan
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid User { get; set; }
        public long Price { get; set; }
    }
