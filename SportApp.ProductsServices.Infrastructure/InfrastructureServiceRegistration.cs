namespace SportApp.ProductsServices.Infrastructure ;
using Application.ProductService.Interfaces;
using Application.ProductService.UseCases;
using Domain.ProductService.Repositories;
using EntityFramework;
using EntityFramework.ProductService.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProductServiceContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ConnectionString"))
                );

            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));

            services.AddScoped<IProductServiceRepository, ProductServiceRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IPlanRepository, PlanRepository>();
            services.AddScoped<IServiceTypeRepository, ServiceTypeRepository>();
            services.AddScoped<IGeographicInfoRepository, GeographicInfoRepository>();
            services.AddScoped<ITypeOfNutritionRepository, TypeOfNutritionRepository>();


            services.AddScoped<ICreateCategory, CreateCategoryUseCase>();
            services.AddScoped<ICreateProductService, CreateProductServiceUseCase>();
            services.AddScoped<ICreateServiceType, CreateServiceTypeUseCase>();
            services.AddScoped<ICreatePlan, CreatePlanUseCase>();
            services.AddScoped<ICreateGeographicInfo, CreateGeographicInfoUseCase>();
            services.AddScoped<ICreateTypeOfNutrition, CreateTypeOfNutritionUseCase>();
            //services.AddScoped<IStreamerRepository, StreamerRepository>();

            //services.Configure<EmailSettings>(c => configuration.GetSection("EmailSettings"));
            //services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
