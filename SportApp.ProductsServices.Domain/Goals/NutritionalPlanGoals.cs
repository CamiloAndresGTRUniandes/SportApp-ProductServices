namespace SportApp.ProductsServices.Domain.Goals ;
using Nutrition;

    public class NutritionalPlanGoals
    {
        public NutritionalPlan NutritionalPlan { get; set; }
        public Goal Goal { get; set; }

        public static NutritionalPlanGoals Build(NutritionalPlan nutritionalPlan, Goal goal)
        {
            var nutritionalPlanGoals = nutritionalPlan.NutritionalPlanGoals.FirstOrDefault(pa => pa.Goal == goal);
            nutritionalPlanGoals ??= goal.NutritionalPlanGoals.FirstOrDefault(pa => pa.NutritionalPlan == nutritionalPlan);
            if (nutritionalPlanGoals != null)
            {
                return nutritionalPlanGoals;
            }
            return new NutritionalPlanGoals
            {
                NutritionalPlan = nutritionalPlan,
                Goal = goal
            };
        }
    }
