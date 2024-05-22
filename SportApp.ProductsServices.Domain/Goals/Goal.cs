namespace SportApp.ProductsServices.Domain.Goals ;

using Common;
using Common.ValueObjects;

    public class Goal : BaseDomainModel
    {
        private readonly List<NutritionalPlanGoals> _nutritionalPlanGoals = new();
        private readonly List<ProductServiceGoals> _productServiceGoals = new();

        protected Goal()
        {
        }

        private Goal(Guid id,
            Name name,
            Guid user)
        {
            Id = id;
            Name = name;
            CreatedBy = user;
            UpdatedBy = user;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
        }

        public Name Name { get; set; }
        public IReadOnlyCollection<ProductServiceGoals> ProductServiceGoals => _productServiceGoals;
        public IReadOnlyCollection<NutritionalPlanGoals> NutritionalPlanGoals => _nutritionalPlanGoals;

        public static Goal Build(
            Guid id,
            Name name,
            Guid user)
        {
            var goal = new Goal(id, name, user);
            goal.SetAdded();
            return goal;
        }
    }
