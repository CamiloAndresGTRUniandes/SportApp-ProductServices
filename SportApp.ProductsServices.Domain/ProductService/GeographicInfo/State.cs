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
        public IReadOnlyCollection<City> City => _cities;

        public State Build(
            Guid id,
            Name name,
            Guid user)
        {
            var state = new State(id, name, user);
            state.SetAdded();
            return state;
        }
    }
