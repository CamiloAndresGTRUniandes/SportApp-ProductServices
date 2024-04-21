namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.GetProductService ;
using Domain.ProductService;
using Domain.ProductService.Commands;

    public class ResponseGetProductService
    {
        public Guid ProductId { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public long Price { get; init; }
        public string Picture { get; init; }
        public Guid CountryId { get; init; }
        public Guid StateId { get; init; }
        public Guid CityId { get; init; }
        public ReferentialDto? Category { get; init; }
        public ReferentialDto? Plan { get; init; }
        public ReferentialDto? ServiceType { get; init; }
        public NutritionalPlanDto? NutritionalPlan { get; init; }
        public Guid? TypeOfNutritionId { get; init; }
        public int SportLevel { get; init; }
        public ICollection<Guid>? Activities { get; init; }
        public ICollection<Guid>? Goals { get; init; }
        public ICollection<Guid>? Allergies { get; init; }
        public DateTime? StartDateTime { get; init; }
        public DateTime? EndDateTime { get; init; }

        public static ICollection<ResponseGetProductService> Build(ICollection<ProductService> productServices)
        {
            return new List<ResponseGetProductService>(productServices.Select(x => new ResponseGetProductService
            {
                ProductId = x.Id,
                Name = x.Name.ToString(),
                Description = x.Description.ToString(),
                Picture = x.Picture.ToString(),
                Price = (long)x.Price!,
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
                Allergies = x.ProductServiceAllergies.Select(p => p.NutritionalAllergy.Id).ToList(),
                NutritionalPlan = x.NutritionalPlan != null
                    ? new NutritionalPlanDto
                    {
                        Days = x.NutritionalPlan.Day.Select(d => new DayDto
                        {
                            Id = d.Id,
                            Name = d.Name.ToString(),
                            Meals = d.Meal.Select(m => new MealDto
                            {
                                Id = m.Id,
                                Name = m.Name.ToString(),
                                Calories = m.Calories,
                                Description = m.Description.ToString(),
                                DishType = m.DishType.Id,
                                Picture = m.Picture
                            }).ToList()
                        }).ToList()
                    }
                    : null
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
                Plan = new ReferentialDto
                {
                    Id = productService.Plan.Id,
                    Name = productService.Plan.Name.ToString()
                },
                Category = new ReferentialDto
                {
                    Id = productService.ServiceType.Category.Id,
                    Name = productService.ServiceType.Category.Name.ToString()
                },
                CountryId = productService.GeographicInfo!.CountryId,
                StateId = productService.GeographicInfo!.StateId,
                CityId = productService.GeographicInfo.CityId,
                TypeOfNutritionId = productService.TypeOfNutrition != null ? productService.TypeOfNutrition.Id : null,
                ServiceType = new ReferentialDto
                {
                    Id = productService.ServiceType.Id,
                    Name = productService.ServiceType.Name.ToString()
                },
                SportLevel = productService.SportLevel!.Id,
                StartDateTime = productService.StartDateTime!,
                EndDateTime = productService.EndDateTime!,
                Activities = productService.ProductServiceActivities.Select(p => p.Activity.Id).ToList(),
                Goals = productService.ProductServiceGoals.Select(p => p.Goal.Id).ToList(),
                Allergies = productService.ProductServiceAllergies.Select(p => p.NutritionalAllergy.Id).ToList(),
                NutritionalPlan = productService.NutritionalPlan != null
                    ? new NutritionalPlanDto
                    {
                        Days = productService.NutritionalPlan.Day.Select(d => new DayDto
                        {
                            Id = d.Id,
                            Name = d.Name.ToString(),
                            Meals = d.Meal.Select(m => new MealDto
                            {
                                Id = m.Id,
                                Name = m.Name.ToString(),
                                Calories = m.Calories,
                                Description = m.Description.ToString(),
                                DishType = m.DishType.Id,
                                Picture = m.Picture
                            }).ToList()
                        }).ToList()
                    }
                    : null
            };
        }
    }

    public class ReferentialDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
