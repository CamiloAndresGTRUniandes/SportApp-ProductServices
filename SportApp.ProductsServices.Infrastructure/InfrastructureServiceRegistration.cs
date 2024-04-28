namespace SportApp.ProductsServices.Infrastructure ;
using Application.Activity.Interfaces;
using Application.Activity.UseCases;
using Application.Goal.Interfaces;
using Application.Goal.UseCases;
using Application.ProductService.Interfaces;
using Application.ProductService.UseCases;
using Application.Subscription.Interfaces;
using Application.Subscription.UseCases;
using Domain.Activities.Repositories;
using Domain.Allergies.Repositories;
using Domain.Goals.Repositories;
using Domain.Nutrition.Repositories;
using Domain.ProductService.Repositories;
using Domain.Subscription.Repositories;
using EntityFramework;
using EntityFramework.Activity.Repositories;
using EntityFramework.Goal.Repositories;
using EntityFramework.Nutrition.Repositories;
using EntityFramework.NutritionalAllergy.Repository;
using EntityFramework.ProductService.Repositories;
using EntityFramework.Subscription;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

    public static class InfrastructureServiceRegistration
    {
        private static string EnvironmentName { get; } = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";

        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            if (EnvironmentName == "Development")
            {
                services.AddDbContext<ProductServiceContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("ConnectionStringLocal"))
                    );
            }
            else
            {
                services.AddDbContext<ProductServiceContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("ConnectionString"))
                    );
            }


            services.AddScoped<IProductServiceRepository, ProductServiceRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IPlanRepository, PlanRepository>();
            services.AddScoped<IServiceTypeRepository, ServiceTypeRepository>();
            services.AddScoped<IGeographicInfoRepository, GeographicInfoRepository>();
            services.AddScoped<ITypeOfNutritionRepository, TypeOfNutritionRepository>();
            services.AddScoped<IGoalRepository, GoalRepository>();
            services.AddScoped<IActivityRepository, ActivityRepository>();
            services.AddScoped<INutritionalAllergyRepository, NutritionalAllergyRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IStateRepository, StateRepository>();
            services.AddScoped<INutritionalPlanRepository, NutritionalPlanRepository>();
            services.AddScoped<ISubscriptionRepository, SubscriptionRepository>();


            services.AddScoped<ICreateCategory, CreateCategoryUseCase>();
            services.AddScoped<ICreateProductService, CreateProductServiceUseCase>();
            services.AddScoped<ICreateServiceType, CreateServiceTypeUseCase>();
            services.AddScoped<ICreatePlan, CreatePlanUseCase>();
            services.AddScoped<ICreateGeographicInfo, CreateGeographicInfoUseCase>();
            services.AddScoped<ICreateTypeOfNutrition, CreateTypeOfNutritionUseCase>();
            services.AddScoped<ICreateTypeOfNutrition, CreateTypeOfNutritionUseCase>();
            services.AddScoped<IGetProductServices, GetProductServicesUseCase>();
            services.AddScoped<ICreateGoal, CreateGoalUseCase>();
            services.AddScoped<ICreateActivity, CreateActivityUseCase>();
            services.AddScoped<IGetServiceTypes, GetServiceTypesUseCase>();
            services.AddScoped<IGetAllCountries, GetAllCountriesUseCase>();
            services.AddScoped<IGetStatesByCountry, GetStatesByCountryUseCase>();
            services.AddScoped<IGetCitiesByState, GetCitiesByStateUseCase>();
            services.AddScoped<IGetAllActivities, GetAllActivitiesUseCase>();
            services.AddScoped<IGetAllTypeOfNutrition, GetAllTypeOfNutritionUseCase>();
            services.AddScoped<IGetAllNutritionalAllergies, GetAllNutritionalAllergiesUseCase>();
            services.AddScoped<IGetAllGoals, GetAllGoalsUseCase>();
            services.AddScoped<IGetAllCategories, GetAllCategoriesUseCase>();
            services.AddScoped<IGetServiceTypesByCategory, GetServiceTypesByCategoryUseCase>();
            services.AddScoped<IGetAllPlans, GetAllPlansUseCase>();
            services.AddScoped<IGetProductService, GetProductServiceUseCase>();
            services.AddScoped<IGetPlanById, GetPlanByIdUseCase>();
            services.AddScoped<IGetServiceTypeById, GetServiceTypeByIdUseCase>();
            services.AddScoped<IGetGoalById, GetGoalByIdUseCase>();
            services.AddScoped<IDeleteProductService, DeleteProductServiceUseCase>();
            services.AddScoped<ICreateSubscription, CreateSubscriptionUseCase>();

            //services.AddScoped<IStreamerRepository, StreamerRepository>();

            //services.Configure<EmailSettings>(c => configuration.GetSection("EmailSettings"));
            //services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
