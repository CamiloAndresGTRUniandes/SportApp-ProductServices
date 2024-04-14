namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Queries;
using Domain.ProductService.Repositories;
using Interfaces;

    public class GetPlanByIdUseCase([NotNull] IPlanRepository planRepository) : IGetPlanById
    {
        public async ValueTask<Plan?> ExecuteAsync(GetPlanByIdQuery request)
        {
            return await planRepository.GetByIdAsync(request.Id);
        }
    }
