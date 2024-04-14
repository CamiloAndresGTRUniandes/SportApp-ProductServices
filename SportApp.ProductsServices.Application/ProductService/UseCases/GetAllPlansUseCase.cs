namespace SportApp.ProductsServices.Application.ProductService.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Queries;
using Domain.ProductService.Repositories;
using Interfaces;

    public class GetAllPlansUseCase([NotNull] IPlanRepository planRepository) : IGetAllPlans
    {
        public async ValueTask<ICollection<Plan>> ExecuteAsync(GetAllPlansQuery request)
        {
            return await planRepository.GetAllActiveAsync();
        }
    }
