namespace SportApp.ProductsServices.Domain.Training.ValueObjects ;

using Common.ValueObjects;

    public sealed class Age(int value) : IntValueObject(value)
    {
        public static implicit operator Age(int age)
        {
            return new Age(age);
        }

        public static implicit operator int(Age age)
        {
            return age.Value;
        }
    }
