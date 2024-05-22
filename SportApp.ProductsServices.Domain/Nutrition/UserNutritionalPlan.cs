namespace SportApp.ProductsServices.Domain.Nutrition ;
using Common;

    public class UserNutritionalPlan : BaseDomainModel
    {
        private readonly List<NutritionalPlanUserNutritionalPlans> _nutritionalPlanUserNutritionalPlans = new();

        protected UserNutritionalPlan()
        {
        }

        private UserNutritionalPlan(
            Guid id)
        {
            SubscribedUser = id;
            CreatedBy = id;
            UpdatedBy = id;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
        }

        public IReadOnlyCollection<NutritionalPlanUserNutritionalPlans> NutritionalPlanUserNutritionalPlans => _nutritionalPlanUserNutritionalPlans;

        public Guid SubscribedUser { get; set; }
    }
