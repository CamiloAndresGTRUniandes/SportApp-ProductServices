namespace SportApp.ProductsServices.Application.Goal ;
using System.Diagnostics.CodeAnalysis;
using Domain.Goals;
using Domain.Goals.Commands;
using Domain.Goals.Repositories;
using Interfaces;

    public class CreateGoalUseCase([NotNull] IGoalRepository goalRepository) : ICreateGoal
    {
        public async ValueTask<Goal> ExecuteAsync(CreateGoalCommand request)
        {
            var goal = Goal.Build(request.Id, request.Name, request.User);
            await goalRepository.SaveAndPublishAsync(goal);
            return goal;
        }
    }
