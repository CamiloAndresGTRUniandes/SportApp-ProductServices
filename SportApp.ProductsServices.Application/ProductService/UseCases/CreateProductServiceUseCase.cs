namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Activity.Exceptions;
using Domain.Activities;
using Domain.Activities.Repositories;
using Domain.Allergies;
using Domain.Allergies.Repositories;
using Domain.Common;
using Domain.Goals;
using Domain.Goals.Repositories;
using Domain.Nutrition;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Domain.ProductService.GeographicInfo;
using Domain.ProductService.Repositories;
using Exceptions;
using Goal.Exception;
using Interfaces;
using NutritionalAllergy.Exceptions;

    public class CreateProductServiceUseCase(
        [NotNull] IProductServiceRepository productServiceRepository,
        [NotNull] IPlanRepository planRepository,
        [NotNull] ITypeOfNutritionRepository typeOfNutritionRepository,
        [NotNull] IGeographicInfoRepository geographicInfoRepository,
        [NotNull] IServiceTypeRepository serviceTypeRepository,
        [NotNull] IGoalRepository goalRepository,
        [NotNull] IActivityRepository activityRepository,
        [NotNull] INutritionalAllergyRepository nutritionalAllergyRepository) : ICreateProductService
    {
        public async ValueTask<ProductService> ExecuteAsync(CreateProductServiceCommand request)
        {
            var productService = await productServiceRepository.GetByIdAsync(request.Id);
            Plan? plan = null;
            TypeOfNutrition? typOfNutrition = null;
            var newGoals = new List<Goal>();
            var newActivities = new List<Activity>();
            var newAllergies = new List<NutritionalAllergy>();
            if (request.PlanId.HasValue)
            {
                plan = await planRepository.GetByIdAsync(request.PlanId.Value);
                if (plan is null)
                {
                    throw new PlanNotFoundConflictException(request.PlanId.Value);
                }
            }

            if (request.TypeOfNutritionId.HasValue)
            {
                typOfNutrition = await typeOfNutritionRepository.GetByIdAsync(request.TypeOfNutritionId.Value);
                if (typOfNutrition is null)
                {
                    throw new TypeOfNutritionNotFoundConflictException(request.TypeOfNutritionId.Value);
                }
            }

            if (request.Goals!.Count != 0)
            {
                foreach (var goalId in request.Goals)
                {
                    var goal = await goalRepository.GetByIdAsync(goalId) ?? throw new GoalNotFoundConflictException(goalId);
                    newGoals.Add(goal);
                }
            }

            if (request.Activities!.Count != 0)
            {
                foreach (var activityId in request.Activities)
                {
                    var activity = await activityRepository.GetByIdAsync(activityId) ?? throw new ActivityNotFoundConflictException(activityId);
                    newActivities.Add(activity);
                }
            }

            if (request.Allergies!.Count != 0)
            {
                foreach (var allergyId in request.Allergies)
                {
                    var allergy = await nutritionalAllergyRepository.GetByIdAsync(allergyId) ??
                                  throw new NutritionalAllergyNotFoundConflictException(allergyId);
                    newAllergies.Add(allergy);
                }
            }

            var geographicInfo = GeographicInfo.Build(Guid.NewGuid(), request.CountryId, request.StateId, request.CityId, request.User);

            var serviceType = await serviceTypeRepository.GetByIdAsync(request.ServiceTypeId) ??
                              throw new ServiceTypeNotFoundConflictException(request.ServiceTypeId);

            NutritionalPlan nutritionalPlan = null;
            if (request.NutritionalPlan != null)
            {
                nutritionalPlan = NutritionalPlan.Build(Guid.NewGuid(), request.User);
                var days = new List<Day>();
                foreach (var dayDto in request.NutritionalPlan.Days)
                {
                    var day = Day.Build(Guid.NewGuid(), dayDto.Name, request.User);
                    var meals = new List<Meal>();
                    foreach (var mealDto in dayDto.Meals)
                    {
                        var meal = Meal.Build(Guid.NewGuid(), mealDto.Name, mealDto.Description, mealDto.Calories,
                            Enumeration.FromValue<DishType>(mealDto.DishType), mealDto.Picture,
                            request.User);
                        meals.Add(meal);
                    }
                    days.Add(day);
                }
                if (days.Any())
                {
                    nutritionalPlan.AddDays(days);
                }
            }

            if (productService is null)
            {
                productService = ProductService.Build(request.Id, request.Name, request.Description, request.Price, request.Picture, geographicInfo,
                    plan, typOfNutrition, nutritionalPlan, serviceType, request.SportLevel, request.User, request.StartDateTime, request.EndDateTime);
            }
            else
            {
                productService.UpdateProductService(request, plan, typOfNutrition, serviceType);
            }

            productService.AddGoals(newGoals);
            productService.AddActivities(newActivities);
            productService.AddAllergies(newAllergies);
            await productServiceRepository.SaveAndPublishAsync(productService);
            return productService;
        }
    }
