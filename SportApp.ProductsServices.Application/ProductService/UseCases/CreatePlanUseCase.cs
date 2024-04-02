namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Domain.ProductService.Repositories;
using Interfaces;

    public class CreatePlanUseCase(
        [NotNull] IPlanRepository planRepository) : ICreatePlan
    {
        public async ValueTask<Plan> ExecuteAsync(CreatePlanCommand request)
        {
            var plan = Plan.Build(request.Id, request.Name, request.Description, request.Price, request.User);
            await planRepository.SaveAndPublishAsync(plan);
            return plan;
        }
    }
