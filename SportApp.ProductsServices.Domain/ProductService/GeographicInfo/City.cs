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

        public City Build(
            Guid id,
            Name name,
            Guid user)
        {
            var city = new City(id, name, user);
            city.SetAdded();
            return city;
        }
    }
