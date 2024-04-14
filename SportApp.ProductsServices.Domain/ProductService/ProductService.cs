namespace SportApp.ProductsServices.Domain.ProductService ;
using Activities;
using Allergies;
using Commands;
using Common;
using Common.Enums;
using Common.ValueObjects;
using Goals;
using ValueObjects;

    public class ProductService : BaseDomainModel
    {
        private readonly List<ProductServiceActivities> _productServiceActivities = new();
        private readonly List<ProductServiceNutritionalAllergies> _productServiceAllergies = new();
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
            GeographicInfo.GeographicInfo? geographicInfo,
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
        public GeographicInfo.GeographicInfo? GeographicInfo { get; private set; }
        public TypeOfNutrition? TypeOfNutrition { get; private set; }
        public ServiceType ServiceType { get; private set; }
        public SportLevel? SportLevel { get; private set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public IReadOnlyCollection<ProductServiceGoals> ProductServiceGoals => _productServiceGoals;
        public IReadOnlyCollection<ProductServiceNutritionalAllergies> ProductServiceAllergies => _productServiceAllergies;
        public IReadOnlyCollection<ProductServiceActivities> ProductServiceActivities => _productServiceActivities;

        public IReadOnlyCollection<Goal> Goals()
        {
            return ProductServiceGoals.Select(e => e.Goal).ToList();
        }

        public IReadOnlyCollection<Activity> Activities()
        {
            return ProductServiceActivities.Select(e => e.Activity).ToList();
        }

        public IReadOnlyCollection<NutritionalAllergy> Allergies()
        {
            return ProductServiceAllergies.Select(e => e.NutritionalAllergy).ToList();
        }

        public static ProductService Build(
            Guid id,
            Name name,
            Description description,
            Price price,
            Uri picture,
            GeographicInfo.GeographicInfo geographicInfo,
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

        internal void AddGeographicInfo(GeographicInfo.GeographicInfo geographicInfo)
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

        public void AddGoals(IEnumerable<Goal> newGoals)
        {
            if (newGoals != null)
            {
                foreach (var goal in newGoals)
                {
                    AddGoal(goal);
                }
            }
        }

        private void AddGoal(Goal goal)
        {
            if (goal == null || Goals().Any(g => g.Id == goal.Id))
            {
                return;
            }
            _productServiceGoals.Add(Domain.Goals.ProductServiceGoals.Build(this, goal));
            SetModifiedIfNotAdded();
        }

        public void AddActivities(IEnumerable<Activity> newActivities)
        {
            if (newActivities != null)
            {
                foreach (var activity in newActivities)
                {
                    AddActivity(activity);
                }
            }
        }

        private void AddActivity(Activity activity)
        {
            if (activity == null || Activities().Any(g => g.Id == activity.Id))
            {
                return;
            }
            _productServiceActivities.Add(Domain.Activities.ProductServiceActivities.Build(this, activity));
            SetModifiedIfNotAdded();
        }

        public void AddAllergies(IEnumerable<NutritionalAllergy> newAllergies)
        {
            if (newAllergies != null)
            {
                foreach (var allergy in newAllergies)
                {
                    AddAllergy(allergy);
                }
            }
        }

        private void AddAllergy(NutritionalAllergy allergy)
        {
            if (allergy == null || Allergies().Any(g => g.Id == allergy.Id))
            {
                return;
            }
            _productServiceAllergies.Add(ProductServiceNutritionalAllergies.Build(this, allergy));
            SetModifiedIfNotAdded();
        }

        public void UpdateProductService(CreateProductServiceCommand request, Plan plan, TypeOfNutrition typeOfNutrition, ServiceType serviceType)
        {
            if (!Name.Equals(request.Name) && request.Name != null && request.Name != string.Empty)
            {
                Name = request.Name;
            }
            if (!Description.Equals(request.Description) && request.Description != null && request.Description != string.Empty)
            {
                Description = request.Description;
            }
            if (!Description.Equals(request.Description) && request.Description != null && request.Description != string.Empty)
            {
                Description = request.Description;
            }
            if (!Price.Equals(request.Price) && request.Price != null)
            {
                Price = request.Price;
            }
            if (!Picture.Equals(request.Picture) && request.Picture != null)
            {
                Picture = request.Picture;
            }
            if (Plan != plan)
            {
                Plan = plan;
            }
            if (TypeOfNutrition != typeOfNutrition && typeOfNutrition != null)
            {
                TypeOfNutrition = typeOfNutrition;
            }
            if (ServiceType != serviceType)
            {
                ServiceType = serviceType;
            }
            if (SportLevel != request.SportLevel)
            {
                SportLevel = request.SportLevel;
            }
            UpdatedBy = request.User;
            StartDateTime = request.StartDateTime;
            EndDateTime = request.EndDateTime;
            SetModifiedIfNotAdded();
        }
    }
