namespace SportApp.ProductsServices.Domain.ProductService ;

using Common;
using ValueObjects;

    public class TypeOfNutrition : BaseDomainModel
    {
        protected TypeOfNutrition()
        {
        }

        private TypeOfNutrition(
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

        public static TypeOfNutrition Build(
            Guid id,
            Name name,
            Guid user)
        {
            var typeOfNutrition = new TypeOfNutrition(id, name, user);
            typeOfNutrition.SetAdded();
            return typeOfNutrition;
        }
    }
