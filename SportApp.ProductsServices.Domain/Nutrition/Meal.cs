namespace SportApp.ProductsServices.Domain.Nutrition ;
using Common;
using Common.ValueObjects;
using ProductService.Commands;
using ProductService.ValueObjects;
using ValueObjects;

    public class Meal : BaseDomainModel
    {
        protected Meal()
        {
        }

        private Meal(
            Guid id,
            Name name,
            Description description,
            Calories calories,
            DishType dishType,
            Uri picture,
            Guid user)
        {
            Id = id;
            Name = name;
            Description = description;
            Calories = calories;
            DishType = dishType;
            Picture = picture;
            CreatedBy = user;
            UpdatedBy = user;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
        }

        public Name Name { get; set; }
        public Description Description { get; set; }
        public Calories Calories { get; set; }
        public DishType DishType { get; set; }
        public Uri Picture { get; set; }

        public static Meal Build(
            Guid id,
            Name name,
            Description description,
            Calories calories,
            DishType dishType,
            Uri picture,
            Guid user)
        {
            var meal = new Meal(id, name, description, calories, dishType, picture, user);
            meal.SetAdded();
            return meal;
        }

        public void UpdateMeal(MealDto meal, Guid user)
        {
            Name = meal.Name;
            Description = meal.Description;
            Calories = meal.Calories;
            Picture = meal.Picture;
            DishType = Enumeration.ToEnumerator(meal.DishType, DishType.Breakfast);
            UpdatedBy = user;
            UpdatedAt = DateTime.UtcNow;
            SetModifiedIfNotAdded();
        }
    }
