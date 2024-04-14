namespace SportApp.ProductsServices.Domain.ProductService ;

using Common;
using Common.ValueObjects;
using ValueObjects;

    public class Plan : BaseDomainModel
    {
        protected Plan()
        {
        }

        private Plan(
            Guid id,
            Name name,
            Description description,
            Price price,
            Guid user)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            CreatedBy = user;
            UpdatedBy = user;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
        }

        public Name Name { get; }
        public Description Description { get; }
        public Price Price { get; }

        public static Plan Build(
            Guid id,
            Name name,
            Description description,
            Price price,
            Guid user)
        {
            var plan = new Plan(id, name, description, price, user);
            plan.SetAdded();
            return plan;
        }
    }
