namespace SportApp.ProductsServices.Domain.Training ;
using Common;

    public class UserTrainingPlan : BaseDomainModel
    {
        private readonly List<TrainingPlanUserTrainingPlans> _trainingPlanUserTrainingPlans = new();
        public IReadOnlyCollection<TrainingPlanUserTrainingPlans> TrainingPlanUserTrainingPlans => _trainingPlanUserTrainingPlans;
        public Guid SubscribedUser { get; set; }
    }
