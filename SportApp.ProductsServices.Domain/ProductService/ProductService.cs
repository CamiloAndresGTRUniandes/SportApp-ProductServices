namespace SportApp.ProductsServices.Domain.ProductService ;
using Activities;
using Allergies;
using Common;
using Common.Enums;
using Common.ValueObjects;
using Goals;
using ValueObjects;

    public class ProductService : BaseDomainModel
    {
        private readonly List<ProductServiceActivities> _productServiceActivities = new();
        private readonly List<ProductServiceAllergies> _productServiceAllergies = new();
        private readonly List<ProductServiceGoals> _productServiceGoals = new();

        private ProductService()
        {
        }

        private ProductService(
            Guid id,
            Name name,
            Description description,
            Price price,
            Uri picture,
            GeographicInfo? geographicInfo,
            Plan plan,
            TypeOfNutrition? typeOfNutrition,
            ServiceType serviceType,
            SportLevel? sportLevel,
            Guid user,
            DateTime? startDateTime,
            DateTime? endDateTime
            )
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Picture = picture;
            GeographicInfo = geographicInfo;
            Plan = plan;
            ServiceType = serviceType;
            TypeOfNutrition = typeOfNutrition;
            SportLevel = sportLevel;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            CreatedBy = user;
            UpdatedBy = user;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
        }

        public Name Name { get; private set; }
        public Description Description { get; private set; }
        public Price Price { get; private set; }
        public Uri Picture { get; private set; }
        public Plan Plan { get; private set; }
        public GeographicInfo? GeographicInfo { get; private set; }
        public TypeOfNutrition? TypeOfNutrition { get; private set; }
        public ServiceType ServiceType { get; private set; }
        public SportLevel? SportLevel { get; private set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public IReadOnlyCollection<ProductServiceGoals> ProductServiceGoals => _productServiceGoals;
        public IReadOnlyCollection<ProductServiceAllergies> ProductServiceAllergies => _productServiceAllergies;
        public IReadOnlyCollection<ProductServiceActivities> ProductServiceActivities => _productServiceActivities;

        public static ProductService Build(
            Guid id,
            Name name,
            Description description,
            Price price,
            Uri picture,
            GeographicInfo geographicInfo,
            Plan plan,
            TypeOfNutrition typeOfNutrition,
            ServiceType serviceType,
            SportLevel sportLevel,
            Guid user,
            DateTime? startDateTime,
            DateTime? endDateTime
            )
        {
            var productService = new ProductService(
                id,
                name,
                description,
                price,
                picture,
                geographicInfo,
                plan,
                typeOfNutrition,
                serviceType,
                sportLevel,
                user,
                startDateTime,
                endDateTime);
            productService.SetAdded();
            return productService;
        }

        internal void AddPlan(Plan plan)
        {
            Plan = plan;
            SetModifiedIfNotAdded();
        }

        internal void AddGeographicInfo(GeographicInfo geographicInfo)
        {
            GeographicInfo = geographicInfo;
            SetModifiedIfNotAdded();
        }

        internal void AddTypeOfNutrition(TypeOfNutrition typeOfNutrition)
        {
            TypeOfNutrition = typeOfNutrition;
            SetModifiedIfNotAdded();
        }

        internal void AddServiceType(ServiceType serviceType)
        {
            ServiceType = serviceType;
            SetModifiedIfNotAdded();
        }
    }
