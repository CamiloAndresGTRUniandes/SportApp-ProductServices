namespace SportApp.ProductsServices.Domain.ProductService ;
using Common;

    public class GeographicInfo : BaseDomainModel
    {
        protected GeographicInfo()
        {
        }

        private GeographicInfo(
            Guid id,
            Guid countryId,
            Guid stateId,
            Guid cityId,
            Guid user)
        {
            Id = id;
            CountryId = countryId;
            StateId = stateId;
            CityId = cityId;
            CreatedBy = user;
            UpdatedBy = user;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
        }

        public Guid CountryId { get; private set; }
        public Guid StateId { get; private set; }
        public Guid CityId { get; private set; }

        public static GeographicInfo Build(
            Guid id,
            Guid countryId,
            Guid stateId,
            Guid cityId,
            Guid user)
        {
            var geographicInfo = new GeographicInfo(id, countryId, stateId, cityId, user);
            geographicInfo.SetAdded();
            return geographicInfo;
        }
    }
