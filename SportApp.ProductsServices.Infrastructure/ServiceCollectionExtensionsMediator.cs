namespace SportApp.ProductsServices.Infrastructure ;

using Application.ProductService.Handlers;
using Behaviors;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

    public static class ServiceCollectionExtensionsMediator
    {
        public static void AddMediatR(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblyContaining<CreateProductServiceCommandHandler>();

                cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehavior<,>));
            });
        }
    }
