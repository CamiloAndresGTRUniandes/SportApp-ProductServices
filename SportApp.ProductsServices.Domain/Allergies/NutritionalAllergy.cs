namespace SportApp.ProductsServices.Domain.Allergies ;
using Common;
using Common.ValueObjects;

    public class NutritionalAllergy : BaseDomainModel
    {
        private readonly List<ProductServiceNutritionalAllergies> _productServiceAllergies;

        protected NutritionalAllergy()
        {
        }

        private NutritionalAllergy(
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

        public Name Name { get; set; }
        public IReadOnlyCollection<ProductServiceNutritionalAllergies> ProductServiceAllergies => _productServiceAllergies;

        public static NutritionalAllergy Build(
            Guid id,
            Name name,
            Guid user)
        {
            var nutritionalAllergy = new NutritionalAllergy(id, name, user);
            nutritionalAllergy.SetAdded();
            return nutritionalAllergy;
        }
    }
