namespace SportApp.ProductsServices.Infrastructure ;
using Application.Activity.Interfaces;
using Application.Activity.UseCases;
using Application.Goal.Interfaces;
using Application.Goal.UseCases;
using Application.ProductService.Events;
using Application.ProductService.Handlers.EventHandlers;
using Application.ProductService.Interfaces;
using Application.ProductService.UseCases;
using Application.Subscription.Interfaces;
using Application.Subscription.UseCases;
using Domain.Activities.Repositories;
using Domain.Allergies.Repositories;
using Domain.Common.Bus;
using Domain.Goals.Repositories;
using Domain.Nutrition.Repositories;
using Domain.ProductService.Repositories;
using Domain.Subscription.Repositories;
using Domain.Training.Repositories;
using EntityFramework;
using EntityFramework.Activity.Repositories;
using EntityFramework.Goal.Repositories;
using EntityFramework.Nutrition.Repositories;
using EntityFramework.NutritionalAllergy.Repository;
using EntityFramework.ProductService.Repositories;
using EntityFramework.Subscription;
using EntityFramework.Training.Repositories;
using MediatR;
using MessageBus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

    public static class InfrastructureServiceRegistration
    {
        private static string EnvironmentName { get; } = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";

        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            if (EnvironmentName == "Development")
            {
                services.AddDbContext<ProductServiceContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("ConnectionStringLocal"), sqlOptions =>
                    {
                        sqlOptions.EnableRetryOnFailure(
                            3,
                            TimeSpan.FromSeconds(3),
                            null);
                    }
                        ));
            }
            else
            {
                services.AddDbContext<ProductServiceContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("ConnectionString"), sqlOptions =>
                    {
                        sqlOptions.EnableRetryOnFailure(
                            3,
                            TimeSpan.FromSeconds(3),
                            null);
                    }
                        ));
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
            services.AddScoped<ITrainingPlanRepository, TrainingPlanRepository>();


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
            services.AddScoped<IGetSubscription, GetSubscriptionUseCase>();

            //MessageBus
            services.AddSingleton<IEventBus, MessageBus.MessageBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                var optionsFactory = sp.GetService<IOptions<MessageBusSettings>>();
                return new MessageBus.MessageBus(sp.GetService<IMediator>(), scopeFactory, optionsFactory);
            });
            services.AddTransient<IEventHandler<UserProfileEventBus>, UserProfileEventHandler>();
            services.AddTransient<UserProfileEventHandler>();
            //services.AddScoped<IStreamerRepository, StreamerRepository>();

            //services.Configure<EmailSettings>(c => configuration.GetSection("EmailSettings"));
            //services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
