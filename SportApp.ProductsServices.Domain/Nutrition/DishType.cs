namespace SportApp.ProductsServices.Domain.Nutrition ;
using Common;

    public class DishType(int id, string name) : Enumeration(id, name)
    {
        public static readonly DishType Breakfast = new(1, nameof(Breakfast));
        public static readonly DishType Lunch = new(2, nameof(Lunch));
        public static readonly DishType Dinner = new(3, nameof(Dinner));
        public static readonly DishType Snack = new(4, nameof(Snack));
    }
