namespace SportApp.ProductsServices.Domain.Allergies ;
using Common;
using ProductService.ValueObjects;

    public class NutritionalAllergy : BaseDomainModel
    {
        private readonly List<ProductServiceAllergies> _productsServiceAllergies;

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
        public IReadOnlyCollection<ProductServiceAllergies> ProductServiceAllergies => _productsServiceAllergies;

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
