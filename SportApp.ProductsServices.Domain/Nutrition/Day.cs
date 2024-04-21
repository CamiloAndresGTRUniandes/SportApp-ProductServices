namespace SportApp.ProductsServices.Domain.Nutrition ;
using Common;
using Common.ValueObjects;

    public class Day : BaseDomainModel
    {
        private readonly List<Meal> _meals = new();

        protected Day()
        {
        }

        private Day(
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
        public IReadOnlyCollection<Meal> Meal => _meals;

        public static Day Build(Guid id,
            Name name,
            Guid user)
        {
            var day = new Day(id, name, user);
            day.SetAdded();
            return day;
        }

        public void AddMeals(ICollection<Meal> meals)
        {
            foreach (var meal in meals)
            {
                AddMeal(meal);
            }
        }

        private void AddMeal(Meal meal)
        {
            if (meal is null)
            {
                return;
            }
            var currentMeal = _meals.FirstOrDefault(m => m.Id == meal.Id);
            if (currentMeal is null)
            {
                _meals.Add(meal);
            }
            SetModifiedIfNotAdded();
        }
    }
