namespace SportApp.ProductsServices.Domain.ProductService.GeographicInfo ;
using Common;
using Common.ValueObjects;

    public class State : BaseDomainModel
    {
        private readonly List<City> _cities = new();

        protected State()
        {
        }

        private State(
            Guid id,
            Name name,
            Country country,
            Guid user)
        {
            Id = id;
            Name = name;
            CreatedBy = user;
            UpdatedBy = user;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
            Country = country;
        }

        public Name Name { get; set; }
        public Country Country { get; set; }
        public IReadOnlyCollection<City> City => _cities;

        public State Build(
            Guid id,
            Name name,
            Country country,
            Guid user)
        {
            var state = new State(id, name, country, user);
            state.SetAdded();
            return state;
        }
    }
