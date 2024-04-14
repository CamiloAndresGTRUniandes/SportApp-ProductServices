namespace SportApp.ProductsServices.Domain.Goals ;
using Training;

    public class TrainingPlanGoals
    {
        public TrainingPlan TrainingPlan { get; set; }
        public Goal Goal { get; set; }

        public static TrainingPlanGoals Build(TrainingPlan trainingPlan, Goal goal)
        {
            var trainingPlanGoals = trainingPlan.TrainingPlanGoals.FirstOrDefault(pa => pa.Goal == goal);
            trainingPlanGoals ??= goal.TrainingPlanGoals.FirstOrDefault(pa => pa.TrainingPlan == trainingPlan);

            if (trainingPlanGoals != null)
            {
                return trainingPlanGoals;
            }
            return new TrainingPlanGoals { TrainingPlan = trainingPlan, Goal = goal };
        }
    }
