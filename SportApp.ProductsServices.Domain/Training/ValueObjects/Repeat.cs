namespace SportApp.ProductsServices.Domain.Training.ValueObjects ;

using Common.ValueObjects;

    public sealed class Repeat(int value) : IntValueObject(value)
    {
        public static implicit operator Repeat(int repeats)
        {
            return new Repeat(repeats);
        }

        public static implicit operator int(Repeat repeats)
        {
            return repeats.Value;
        }
    }
