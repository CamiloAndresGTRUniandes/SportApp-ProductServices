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
            Guid cityId)
        {
            Id = id;
            CountryId = countryId;
            StateId = stateId;
            CityId = cityId;
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
            Guid cityId)
        {
            var geographicInfo = new GeographicInfo(id, countryId, stateId, cityId);
            geographicInfo.SetAdded();
            return geographicInfo;
        }
    }
