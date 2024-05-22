namespace SportApp.ProductsServices.Domain.Nutrition ;
using Common;
using Common.ValueObjects;
using ProductService.Commands;

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

        public void UpdateDay(DayDto day, Guid user)
        {
            Name = day.Name;
            foreach (var meal in day.Meals)
            {
                var existingMeal = _meals.FirstOrDefault(x => x.Id == meal.Id);
                if (existingMeal != null)
                {
                    existingMeal.UpdateMeal(meal, user);
                }
                else
                {
                    var newMeal = Nutrition.Meal.Build(Guid.NewGuid(), meal.Name, meal.Description, meal.Calories,
                        Enumeration.ToEnumerator(meal.DishType, DishType.Breakfast), meal.Picture, user);
                    _meals.Add(newMeal);
                }
            }
            UpdatedBy = user;
            UpdatedAt = DateTime.Now;
            SetModifiedIfNotAdded();
        }
    }
