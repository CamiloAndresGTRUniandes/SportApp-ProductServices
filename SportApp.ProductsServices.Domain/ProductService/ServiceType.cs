namespace SportApp.ProductsServices.Domain.ProductService ;
using Common;
using Common.ValueObjects;
using ValueObjects;

    public class ServiceType : BaseDomainModel
    {
        protected ServiceType()
        {
        }

        private ServiceType(
            Guid id,
            Name name,
            Description description,
            Uri picture,
            Category category,
            Guid user)
        {
            Id = id;
            Name = name;
            Description = description;
            Picture = picture;
            Category = category;
            CreatedBy = user;
            UpdatedBy = user;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
        }

        public Name Name { get; private set; }
        public Description Description { get; private set; }
        public Uri Picture { get; private set; }
        public Category Category { get; set; }

        public static ServiceType Build(
            Guid id,
            Name name,
            Description description,
            Uri picture,
            Category category,
            Guid user)
        {
            var typeOfNutrition = new ServiceType(id, name, description, picture, category, user);
            typeOfNutrition.SetAdded();
            return typeOfNutrition;
        }
    }
