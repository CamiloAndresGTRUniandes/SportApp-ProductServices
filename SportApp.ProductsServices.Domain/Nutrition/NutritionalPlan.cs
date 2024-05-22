namespace SportApp.ProductsServices.Domain.Nutrition ;
using Common;
using Goals;
using ProductService.Commands;

    public class NutritionalPlan : BaseDomainModel
    {
        private readonly List<Day> _days = new();
        private readonly List<NutritionalPlanGoals> _nutritionalPlanGoals = new();
        private readonly List<NutritionalPlanUserNutritionalPlans> _nutritionalPlanUserNutritionalPlans = new();

        protected NutritionalPlan()
        {
        }

        private NutritionalPlan(
            Guid id,
            Guid user)
        {
            Id = id;
            CreatedBy = user;
            UpdatedBy = user;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
        }

        public IReadOnlyCollection<NutritionalPlanGoals> NutritionalPlanGoals => _nutritionalPlanGoals;
        public IReadOnlyCollection<NutritionalPlanUserNutritionalPlans> NutritionalPlanUserNutritionalPlans => _nutritionalPlanUserNutritionalPlans;
        public IReadOnlyCollection<Day> Day => _days;

        public static NutritionalPlan Build(
            Guid id,
            Guid user)
        {
            var nutritionalPlan = new NutritionalPlan(id, user);
            nutritionalPlan.SetAdded();
            return nutritionalPlan;
        }

        public void AddDays(ICollection<Day> days)
        {
            foreach (var day in days)
            {
                AddDay(day);
            }
        }

        private void AddDay(Day day)
        {
            if (day == null)
            {
                return;
            }
            var currentDay = _days.FirstOrDefault(x => x.Id == day.Id);
            if (currentDay == null)
            {
                _days.Add(day);
            }
            SetModifiedIfNotAdded();
        }

        public void UpdateNutritionalPlan(NutritionalPlanDto newNutritionalPlan, Guid user)
        {
            foreach (var day in newNutritionalPlan.Days)
            {
                var existingDay = _days.FirstOrDefault(x => x.Id == day.Id);
                if (existingDay != null)
                {
                    existingDay.UpdateDay(day, user);
                }
                else
                {
                    var newDay = Nutrition.Day.Build(Guid.NewGuid(), day.Name, user);
                    newDay.AddMeals(
                        day.Meals.Select(
                            x =>
                                Meal.Build(Guid.Empty, x.Name, x.Description, x.Calories, Enumeration.ToEnumerator(x.DishType, DishType.Breakfast),
                                    x.Picture, user)).ToList());
                    _days.Add(newDay);
                }
            }
            UpdatedBy = user;
            UpdatedAt = DateTime.Now;
            SetModifiedIfNotAdded();
        }
    }
