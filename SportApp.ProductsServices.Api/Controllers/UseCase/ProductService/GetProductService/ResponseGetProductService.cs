namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.GetProductService ;
using Domain.Common.Enums;
using Domain.ProductService;

    public class ResponseGetProductService
    {
        public Guid Id { get; set; }
        public string Name { get; init; }
        public string Description { get; init; }
        public long Price { get; init; }
        public string Picture { get; init; }
        public PlanDto Plan { get; init; }
        public GeographicInfoDto GeographicInfo { get; init; }
        public TypeOfNutritionDto TypeOfNutrition { get; init; }
        public ServiceTypeDto ServiceType { get; init; }
        public SportLevel SportLevel { get; init; }
        public ICollection<ActivityDto> Activities { get; init; }
        public ICollection<GoalDto> Goals { get; init; }
        public ICollection<AllergyDto> Allergies { get; init; }
        public DateTime? StarDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }

        public static ICollection<ResponseGetProductService> Build(ICollection<ProductService> productServices)
        {
            return new List<ResponseGetProductService>(productServices.Select(x => new ResponseGetProductService
            {
                Id = x.Id,
                Name = x.Name.ToString(),
                Description = x.Description.ToString(),
                Picture = x.Picture.ToString(),
                Price = (long)x.Price!,
                Plan = new PlanDto
                {
                    Id = x.Plan.Id,
                    Name = x.Plan.Name,
                    Description = x.Plan.Description.ToString(),
                    Price = (long)x.Plan.Price!
                },
                GeographicInfo = x.GeographicInfo != null
                    ? new GeographicInfoDto
                    {
                        Id = x.GeographicInfo!.Id,
                        CountryId = x.GeographicInfo!.CountryId,
                        CityId = x.GeographicInfo!.CityId,
                        StateId = x.GeographicInfo!.StateId
                    }
                    : null,
                TypeOfNutrition = x.TypeOfNutrition != null
                    ? new TypeOfNutritionDto
                    {
                        Id = x.TypeOfNutrition!.Id,
                        Name = x.TypeOfNutrition!.Name
                    }
                    : null,
                ServiceType = new ServiceTypeDto
                {
                    Id = x.ServiceType.Id,
                    Name = x.ServiceType.Name.ToString(),
                    Description = x.ServiceType.Description.ToString(),
                    Picture = x.ServiceType.Picture.ToString(),
                    Category = new CategoryDto
                    {
                        Id = x.ServiceType.Category.Id,
                        Name = x.ServiceType.Category.Name
                    }
                },
                SportLevel = x.SportLevel!,
                StarDateTime = x.StartDateTime!,
                EndDateTime = x.EndDateTime!,
                Activities = x.ProductServiceActivities.Select(p => new ActivityDto
                {
                    Id = p.Activity.Id,
                    Name = p.Activity.Name.ToString()
                }).ToList(),
                Goals = x.ProductServiceGoals.Select(p => new GoalDto
                {
                    Id = p.Goal.Id,
                    Name = p.Goal.Name.ToString()
                }).ToList(),
                Allergies = x.ProductServiceAllergies.Select(p => new AllergyDto
                {
                    Id = p.NutritionalAllergy.Id,
                    Name = p.NutritionalAllergy.Name.ToString()
                }).ToList()
            }));
        }

        public class PlanDto
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public long Price { get; set; }
        }

        public class GeographicInfoDto
        {
            public Guid Id { get; init; }
            public Guid CountryId { get; init; }
            public Guid StateId { get; init; }
            public Guid CityId { get; init; }
        }

        public class TypeOfNutritionDto
        {
            public Guid Id { get; init; }
            public string Name { get; init; }
        }

        public class ServiceTypeDto
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Picture { get; set; }
            public CategoryDto Category { get; set; }
        }

        public class CategoryDto
        {
            public Guid Id { get; init; }
            public string Name { get; init; }
        }

        public class ActivityDto
        {
            public Guid Id { get; init; }
            public string Name { get; init; }
        }

        public class GoalDto
        {
            public Guid Id { get; init; }
            public string Name { get; init; }
        }

        public class AllergyDto
        {
            public Guid Id { get; init; }
            public string Name { get; init; }
        }
    }
