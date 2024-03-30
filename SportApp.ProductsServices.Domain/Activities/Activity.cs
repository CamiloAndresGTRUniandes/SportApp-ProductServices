namespace SportApp.ProductsServices.Domain.Activities ;
using Common;
using ProductService.ValueObjects;

    public class Activity : BaseDomainModel
    {
        private readonly List<ProductServiceActivities> _productServiceActivities = new();

        protected Activity()
        {
        }

        private Activity(
            Guid id,
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

        public Name Name { get; private set; }
        public IReadOnlyCollection<ProductServiceActivities> ProductServiceActivities => _productServiceActivities;

        public static Activity Build(
            Guid id,
            Name name,
            Guid user)
        {
            var activity = new Activity(id, name, user);
            activity.SetAdded();
            return activity;
        }
    }
