namespace SportApp.ProductsServices.Domain.ProductService.GeographicInfo ;
using Common;
using Common.ValueObjects;

    public class Country : BaseDomainModel
    {
        private readonly List<State> _states = new();

        protected Country()
        {
        }

        private Country(Guid id, Name name, Guid user)
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
        public IReadOnlyCollection<State> State => _states;

        public Country Build(Guid id, Name name, Guid user)
        {
            var country = new Country(id, name, user);
            country.SetAdded();
            return country;
        }
    }
