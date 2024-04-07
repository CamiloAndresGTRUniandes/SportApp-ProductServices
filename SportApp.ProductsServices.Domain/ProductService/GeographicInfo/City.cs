namespace SportApp.ProductsServices.Domain.ProductService.GeographicInfo ;
using Common;
using Common.ValueObjects;

    public sealed class City : BaseDomainModel
    {
        protected City()
        {
        }

        private City(
            Guid id,
            Name name,
            State state,
            Guid user)
        {
            Id = id;
            Name = name;
            CountryState = state;
            CreatedBy = user;
            UpdatedBy = user;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
        }

        public Name Name { get; set; }
        public State CountryState { get; set; }

        public City Build(
            Guid id,
            Name name,
            State state,
            Guid user)
        {
            var city = new City(id, name, state, user);
            city.SetAdded();
            return city;
        }
    }
