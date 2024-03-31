namespace SportApp.ProductsServices.Domain.Activities ;
using Training;

    public class TrainingPlanActivities
    {
        public TrainingPlan TrainingPlan { get; set; }
        public Activity Activity { get; set; }

        public static TrainingPlanActivities Build(TrainingPlan trainingPlan, Activity activity)
        {
            var trainingPlanActivities = trainingPlan.TrainingPlanActivities.FirstOrDefault(pa => pa.Activity == activity);
            trainingPlanActivities ??= activity.TrainingPlanActivities.FirstOrDefault(pa => pa.TrainingPlan == trainingPlan);

            if (trainingPlanActivities != null)
            {
                return trainingPlanActivities;
            }
            return new TrainingPlanActivities { TrainingPlan = trainingPlan, Activity = activity };
        }
    }
