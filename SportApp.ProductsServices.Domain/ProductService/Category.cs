namespace SportApp.ProductsServices.Domain.ProductService ;
using Common;
using Common.ValueObjects;
using ValueObjects;

    public class Category : BaseDomainModel
    {
        private readonly List<ServiceType> _serviceTypes = new();

        protected Category()
        {
        }

        private Category(
            Guid id,
            Name name,
            Description description,
            Guid user)
        {
            Id = id;
            Name = name;
            Description = description;
            CreatedBy = user;
            UpdatedBy = user;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
        }

        public Name Name { get; private set; }
        public Description Description { get; private set; }
        public IReadOnlyCollection<ServiceType> ServiceType => _serviceTypes;

        public static Category Build(
            Guid id,
            Name name,
            Description description,
            Guid user)
        {
            var typeOfNutrition = new Category(id, name, description, user);
            typeOfNutrition.SetAdded();
            return typeOfNutrition;
        }
    }
