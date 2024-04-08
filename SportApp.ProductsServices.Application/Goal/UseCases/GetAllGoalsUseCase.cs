namespace SportApp.ProductsServices.Application.Goal.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.Goals;
using Domain.Goals.Queries;
using Domain.Goals.Repositories;
using Interfaces;

    public class GetAllGoalsUseCase([NotNull] IGoalRepository goalRepository) : IGetAllGoals
    {
        public async ValueTask<ICollection<Goal>> ExecuteAsync(GetAllGoalsQuery request)
        {
            return await goalRepository.GetAllActiveAsync();
        }
    }
