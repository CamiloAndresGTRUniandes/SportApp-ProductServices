namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.GetProductService ;
using Domain.ProductService;

    public class ResponseGetProductService
    {
        public Guid ProductId { get; set; }
        public string Name { get; init; }
        public string Description { get; init; }
        public long Price { get; init; }
        public string Picture { get; init; }
        public Guid PlanId { get; init; }
        public Guid CountryId { get; set; }
        public Guid StateId { get; set; }
        public Guid CityId { get; set; }
        public ReferentialDto? Category { get; set; }
        public ReferentialDto? Plan { get; set; }
        public ReferentialDto? ServiceType { get; set; }
        public Guid? TypeOfNutritionId { get; init; }
        public Guid ServiceTypeId { get; init; }
        public int SportLevel { get; init; }
        public ICollection<Guid>? Activities { get; init; }
        public ICollection<Guid>? Goals { get; init; }
        public ICollection<Guid>? Allergies { get; init; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }

        public static ICollection<ResponseGetProductService> Build(ICollection<ProductService> productServices)
        {
            return new List<ResponseGetProductService>(productServices.Select(x => new ResponseGetProductService
            {
                ProductId = x.Id,
                Name = x.Name.ToString(),
                Description = x.Description.ToString(),
                Picture = x.Picture.ToString(),
                Price = (long)x.Price!,
                PlanId = x.Plan.Id,
                Plan = new ReferentialDto
                {
                    Id = x.Plan.Id,
                    Name = x.Plan.Name.ToString()
                },
                Category = new ReferentialDto
                {
                    Id = x.ServiceType.Category.Id,
                    Name = x.ServiceType.Category.Name.ToString()
                },
                CountryId = x.GeographicInfo!.CountryId,
                StateId = x.GeographicInfo!.StateId,
                CityId = x.GeographicInfo.CityId,
                TypeOfNutritionId = x.TypeOfNutrition != null ? x.TypeOfNutrition.Id : null,
                ServiceTypeId = x.ServiceType.Id,
                ServiceType = new ReferentialDto
                {
                    Id = x.ServiceType.Id,
                    Name = x.ServiceType.Name.ToString()
                },
                SportLevel = x.SportLevel!.Id,
                StartDateTime = x.StartDateTime!,
                EndDateTime = x.EndDateTime!,
                Activities = x.ProductServiceActivities.Select(p => p.Activity.Id).ToList(),
                Goals = x.ProductServiceGoals.Select(p => p.Goal.Id).ToList(),
                Allergies = x.ProductServiceAllergies.Select(p => p.NutritionalAllergy.Id).ToList()
            }));
        }

        public static ResponseGetProductService Build(ProductService productService)
        {
            return new ResponseGetProductService
            {
                ProductId = productService.Id,
                Name = productService.Name.ToString(),
                Description = productService.Description.ToString(),
                Picture = productService.Picture.ToString(),
                Price = (long)productService.Price!,
                PlanId = productService.Plan.Id,
                Category = new ReferentialDto
                {
                    Id = productService.ServiceType.Category.Id,
                    Name = productService.ServiceType.Category.Name.ToString()
                },
                CountryId = productService.GeographicInfo!.CountryId,
                StateId = productService.GeographicInfo!.StateId,
                CityId = productService.GeographicInfo.CityId,
                TypeOfNutritionId = productService.TypeOfNutrition != null ? productService.TypeOfNutrition.Id : null,
                ServiceTypeId = productService.ServiceType.Id,
                SportLevel = productService.SportLevel!.Id,
                StartDateTime = productService.StartDateTime!,
                EndDateTime = productService.EndDateTime!,
                Activities = productService.ProductServiceActivities.Select(p => p.Activity.Id).ToList(),
                Goals = productService.ProductServiceGoals.Select(p => p.Goal.Id).ToList(),
                Allergies = productService.ProductServiceAllergies.Select(p => p.NutritionalAllergy.Id).ToList()
            };
        }
    }

    public class ReferentialDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
