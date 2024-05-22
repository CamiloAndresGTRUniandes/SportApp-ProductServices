namespace SportApp.ProductsServices.Domain.Nutrition.ValueObjects ;
using Common.ValueObjects;

    public class Calories(int value) : IntValueObject(value)
    {
        public static implicit operator Calories(int calories)
        {
            return new Calories(calories);
        }

        public static implicit operator int(Calories calories)
        {
            return calories.Value;
        }
    }
