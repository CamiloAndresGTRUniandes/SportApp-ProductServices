namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.GetServiceType ;
using Domain.ProductService;

    public class ResponseGetServiceTypes
    {
        public Guid Id { get; set; }
        public string Name { get; init; }
        public string Description { get; init; }
        public string Picture { get; init; }
        public ServiceTypeCategoryDto Category { get; init; }

        public static ICollection<ResponseGetServiceTypes> Build(ICollection<ServiceType> serviceTypes)
        {
            return new List<ResponseGetServiceTypes>(serviceTypes.Select(x => new ResponseGetServiceTypes
            {
                Id = x.Id,
                Name = x.Name.ToString(),
                Description = x.Description.ToString(),
                Picture = x.Picture.ToString(),
                Category = new ServiceTypeCategoryDto
                {
                    Id = x.Category.Id,
                    Name = x.Category.Name
                }
            }).ToList());
        }

        public class ServiceTypeCategoryDto
        {
            public Guid Id { get; init; }
            public string Name { get; init; }
        }
    }
