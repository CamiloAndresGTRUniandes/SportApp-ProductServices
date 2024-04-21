namespace SportApp.ProductsServices.Application.Goal.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.Goals;
using Domain.Goals.Queries;
using Domain.Goals.Repositories;
using Interfaces;

    public class GetGoalByIdUseCase([NotNull] IGoalRepository goalRepository) : IGetGoalById
    {
        public async ValueTask<Goal?> ExecuteAsync(GetGoalByIdQuery request)
        {
            return await goalRepository.GetByIdAsync(request.Id);
        }
    }
