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
using Domain.Nutrition.Repositories;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Domain.ProductService.GeographicInfo;
using Domain.ProductService.Repositories;
using Domain.Training;
using Domain.Training.Repositories;
using Exceptions;
using Goal.Exception;
using Interfaces;
using NutritionalAllergy.Exceptions;

    public class CreateProductServiceUseCase(
        [NotNull] IProductServiceRepository productServiceRepository,
        [NotNull] IPlanRepository planRepository,
        [NotNull] ITypeOfNutritionRepository typeOfNutritionRepository,
        [NotNull] IServiceTypeRepository serviceTypeRepository,
        [NotNull] IGoalRepository goalRepository,
        [NotNull] IActivityRepository activityRepository,
        [NotNull] INutritionalAllergyRepository nutritionalAllergyRepository,
        [NotNull] INutritionalPlanRepository nutritionalPlanRepository,
        [NotNull] ITrainingPlanRepository trainingPlanRepository) : ICreateProductService
    {
        private const string CategoryId = "03388722-321F-4B6A-963E-104EB73D17C2";

        public async ValueTask<ProductService> ExecuteAsync(CreateProductServiceCommand request)
        {
            var productService = await productServiceRepository.GetByIdAsync(request.Id);
            var plan = await GetPlanAsync(request);
            var typOfNutrition = await GetTypeOfNutritionAsync(request);
            var newGoals = await GetGoalsAsync(request);
            var newActivities = await GetActivitiesAsync(request);
            var newAllergies = await GetAllergiesAsync(request);

            var geographicInfo = GeographicInfo.Build(Guid.NewGuid(), request.CountryId, request.StateId, request.CityId, request.User);

            var serviceType = await serviceTypeRepository.GetByIdAsync(request.ServiceTypeId) ??
                              throw new ServiceTypeNotFoundConflictException(request.ServiceTypeId);

            var nutritionalPlan = await CreateOrUpdateNutritionalPlanAsync(productService, serviceType, request);
            var trainingPlan = await CreateOrUpdateTrainingPlanAsync(productService, serviceType, request);
            if (productService is null)
            {
                productService = ProductService.Build(request.Id, request.Name, request.Description, request.Price, request.Picture, geographicInfo,
                    plan, typOfNutrition, nutritionalPlan, trainingPlan, serviceType, request.SportLevel, request.User, request.StartDateTime,
                    request.EndDateTime);
            }
            else
            {
                productService = await productServiceRepository.GetByIdAsync(productService.Id);
                productService.UpdateProductService(request, plan, typOfNutrition, serviceType, nutritionalPlan, trainingPlan);
            }

            productService.AddGoals(newGoals);
            productService.AddActivities(newActivities);
            productService.AddAllergies(newAllergies);
            await productServiceRepository.SaveAndPublishAsync(productService);
            return productService;
        }

        private async Task<NutritionalPlan> CreateOrUpdateNutritionalPlanAsync(ProductService productService, ServiceType? serviceType,
            CreateProductServiceCommand request)
        {
            NutritionalPlan nutritionalPlan = null;
            if (request.NutritionalPlan != null)
            {
                if (productService != null)
                {
                    productService.DeleteNutritionalPlan();
                    await productServiceRepository.SaveAndPublishAsync(productService);
                }
                if (serviceType!.Category.Id == Guid.Parse(CategoryId) && request.NutritionalPlan!.Days!.First().Name != string.Empty)
                {
                    nutritionalPlan = NutritionalPlan.Build(Guid.NewGuid(), request.User);
                    var days = new List<Day>();
                    foreach (var dayDto in request.NutritionalPlan.Days!)
                    {
                        var day = Day.Build(Guid.NewGuid(), dayDto.Name, request.User);
                        var meals = new List<Meal>();
                        foreach (var mealDto in dayDto.Meals!)
                        {
                            var meal = Meal.Build(Guid.NewGuid(), mealDto.Name, mealDto.Description, mealDto.Calories,
                                Enumeration.ToEnumerator(mealDto.DishType, DishType.Breakfast), mealDto.Picture,
                                request.User);
                            meals.Add(meal);
                        }
                        if (meals.Any())
                        {
                            day.AddMeals(meals);
                        }
                        days.Add(day);
                    }
                    if (days.Any())
                    {
                        nutritionalPlan.AddDays(days);
                    }
                    if (productService != null)
                    {
                        await nutritionalPlanRepository.SaveAndPublishAsync(nutritionalPlan);
                    }
                }
            }
            return nutritionalPlan;
        }

        private async Task<TrainingPlan> CreateOrUpdateTrainingPlanAsync(ProductService productService, ServiceType? serviceType,
            CreateProductServiceCommand request)
        {
            TrainingPlan trainingPlan = null;
            if (request.TrainingPlan != null)
            {
                if (productService != null)
                {
                    productService.DeleteTrainingPlan();
                    await productServiceRepository.SaveAndPublishAsync(productService);
                }
                if (serviceType!.Category.Id == Guid.Parse(CategoryId) && request.TrainingPlan!.Trainings!.First().Name != string.Empty)
                {
                    trainingPlan = TrainingPlan.Build(Guid.NewGuid(), request.TrainingPlan.StartAge, request.TrainingPlan.EndAge,
                        request.User);
                    var trainings = new List<Training>();
                    foreach (var trainingDto in request.TrainingPlan.Trainings!)
                    {
                        var training = Training.Build(Guid.NewGuid(), trainingDto.Name, trainingDto.Description, request.User);
                        var exercises = new List<Exercise>();
                        foreach (var exerciseDto in trainingDto.Exercises!)
                        {
                            var exercise = Exercise.Build(Guid.NewGuid(), exerciseDto.Name, exerciseDto.Description, exerciseDto.Sets,
                                exerciseDto.Repeats, exerciseDto.Weight, exerciseDto.Picture, request.User);
                            exercises.Add(exercise);
                        }
                        if (exercises.Any())
                        {
                            training.AddExercises(exercises);
                        }
                        trainings.Add(training);
                    }
                    if (trainings.Any())
                    {
                        trainingPlan.AddTrainings(trainings);
                    }
                    if (productService != null)
                    {
                        await trainingPlanRepository.SaveAndPublishAsync(trainingPlan);
                    }
                }
            }
            return trainingPlan;
        }

        private async Task<Plan> GetPlanAsync(CreateProductServiceCommand request)
        {
            Plan plan = null;
            if (request.PlanId.HasValue)
            {
                plan = await planRepository.GetByIdAsync(request.PlanId.Value);
                if (plan is null)
                {
                    throw new PlanNotFoundConflictException(request.PlanId.Value);
                }
            }
            return plan;
        }

        private async Task<TypeOfNutrition> GetTypeOfNutritionAsync(CreateProductServiceCommand request)
        {
            TypeOfNutrition typOfNutrition = null;
            if (request.TypeOfNutritionId.HasValue)
            {
                typOfNutrition = await typeOfNutritionRepository.GetByIdAsync(request.TypeOfNutritionId.Value);
                if (typOfNutrition is null)
                {
                    throw new TypeOfNutritionNotFoundConflictException(request.TypeOfNutritionId.Value);
                }
            }
            return typOfNutrition;
        }

        private async Task<List<Goal>> GetGoalsAsync(CreateProductServiceCommand request)
        {
            var newGoals = new List<Goal>();
            if (request.Goals!.Count != 0)
            {
                foreach (var goalId in request.Goals)
                {
                    var goal = await goalRepository.GetByIdAsync(goalId) ?? throw new GoalNotFoundConflictException(goalId);
                    newGoals.Add(goal);
                }
            }
            return newGoals;
        }

        private async Task<List<Activity>> GetActivitiesAsync(CreateProductServiceCommand request)
        {
            var newActivities = new List<Activity>();
            if (request.Activities!.Count != 0)
            {
                foreach (var activityId in request.Activities)
                {
                    var activity = await activityRepository.GetByIdAsync(activityId) ?? throw new ActivityNotFoundConflictException(activityId);
                    newActivities.Add(activity);
                }
            }
            return newActivities;
        }

        private async Task<List<NutritionalAllergy>> GetAllergiesAsync(CreateProductServiceCommand request)
        {
            var newAllergies = new List<NutritionalAllergy>();
            if (request.Allergies!.Count != 0)
            {
                foreach (var allergyId in request.Allergies)
                {
                    var allergy = await nutritionalAllergyRepository.GetByIdAsync(allergyId) ??
                                  throw new NutritionalAllergyNotFoundConflictException(allergyId);
                    newAllergies.Add(allergy);
                }
            }
            return newAllergies;
        }
    }
