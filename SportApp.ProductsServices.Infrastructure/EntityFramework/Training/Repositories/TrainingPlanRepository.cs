namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Training.Repositories ;
using System.Diagnostics.CodeAnalysis;
using Domain.Training;
using Domain.Training.Repositories;
using Microsoft.EntityFrameworkCore;

    public class TrainingPlanRepository([NotNull] ProductServiceContext context) : ITrainingPlanRepository
    {
        public async Task SaveAndPublishAsync(TrainingPlan trainingPlan)
        {
            if (trainingPlan.EntityState is EntityState.Added)
            {
                await context.TrainingPlans.AddAsync(trainingPlan);
            }
            else
            {
                context.TrainingPlans.Attach(trainingPlan);
            }
            await context.SaveChangesAsync();
        }
    }
