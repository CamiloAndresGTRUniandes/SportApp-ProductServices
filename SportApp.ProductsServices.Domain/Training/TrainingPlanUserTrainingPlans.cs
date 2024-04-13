namespace SportApp.ProductsServices.Domain.Training ;

    public class TrainingPlanUserTrainingPlans
    {
        public TrainingPlan TrainingPlan { get; set; }
        public UserTrainingPlan UserTrainingPlan { get; set; }

        public static TrainingPlanUserTrainingPlans Build(TrainingPlan trainingPlan, UserTrainingPlan userTrainingPlan)
        {
            var trainingPlanUserTrainingPlans =
                trainingPlan.TrainingPlanUserTrainingPlans.FirstOrDefault(pa => pa.UserTrainingPlan == userTrainingPlan);
            trainingPlanUserTrainingPlans ??= userTrainingPlan.TrainingPlanUserTrainingPlans.FirstOrDefault(pa => pa.TrainingPlan == trainingPlan);

            if (trainingPlanUserTrainingPlans != null)
            {
                return trainingPlanUserTrainingPlans;
            }
            return new TrainingPlanUserTrainingPlans { TrainingPlan = trainingPlan, UserTrainingPlan = userTrainingPlan };
        }
    }
