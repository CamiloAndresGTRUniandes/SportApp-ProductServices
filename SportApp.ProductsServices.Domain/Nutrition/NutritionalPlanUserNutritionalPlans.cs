namespace SportApp.ProductsServices.Domain.Nutrition ;

    public class NutritionalPlanUserNutritionalPlans
    {
        public NutritionalPlan NutritionalPlan { get; set; }
        public UserNutritionalPlan UserNutritionalPlan { get; set; }

        public static NutritionalPlanUserNutritionalPlans Build(NutritionalPlan nutritionalPlan, UserNutritionalPlan userNutritionalPlan)
        {
            var nutritionalPlanUserNutritionalPlans =
                nutritionalPlan.NutritionalPlanUserNutritionalPlans.FirstOrDefault(pa => pa.UserNutritionalPlan == userNutritionalPlan);
            nutritionalPlanUserNutritionalPlans ??=
                userNutritionalPlan.NutritionalPlanUserNutritionalPlans.FirstOrDefault(pa => pa.NutritionalPlan == nutritionalPlan);

            if (nutritionalPlanUserNutritionalPlans != null)
            {
                return nutritionalPlanUserNutritionalPlans;
            }
            return new NutritionalPlanUserNutritionalPlans { NutritionalPlan = nutritionalPlan, UserNutritionalPlan = userNutritionalPlan };
        }
    }
