namespace SportApp.ProductServices.Application.UnitTest.Data ;
using ProductsServices.Domain.ProductService;

    public class ServiceTypeMother
    {
        public static ServiceType Create(
            string id = "84aa7479-d3bf-4b94-b4d6-f837ff917e48",
            string name = "Service type name",
            string description = "Service type description",
            string url = "https://google.com",
            Category category = null,
            string user = "565e6aca-8dbe-4412-a5ba-26680ffee83d"
            )
        {
            return ServiceType.Build(Guid.Parse(id), name, description, new Uri(url), category is null ? CategoryMother.Create() : category,
                Guid.Parse(user));
        }
    }
