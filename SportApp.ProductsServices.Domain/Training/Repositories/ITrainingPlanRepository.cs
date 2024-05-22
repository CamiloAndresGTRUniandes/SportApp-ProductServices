namespace SportApp.ProductsServices.Domain.Training.Repositories ;

    public interface ITrainingPlanRepository
    {
        Task SaveAndPublishAsync(TrainingPlan trainingPlan);
    }
