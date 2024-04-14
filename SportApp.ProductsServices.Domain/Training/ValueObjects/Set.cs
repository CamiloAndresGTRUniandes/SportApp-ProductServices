namespace SportApp.ProductsServices.Domain.Training.ValueObjects ;

using Common.ValueObjects;

    public sealed class Set(int value) : IntValueObject(value)
    {
        public static implicit operator Set(int sets)
        {
            return new Set(sets);
        }

        public static implicit operator int(Set sets)
        {
            return sets.Value;
        }
    }
