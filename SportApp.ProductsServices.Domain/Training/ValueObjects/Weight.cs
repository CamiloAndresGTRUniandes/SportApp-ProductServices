namespace SportApp.ProductsServices.Domain.Training.ValueObjects ;
using Common.ValueObjects;

    public class Weight(long? value) : LongNullableValueObject(value)
    {
        public static implicit operator Weight(long? size)
        {
            return new Weight(size);
        }

        public static implicit operator long?(Weight size)
        {
            return size?.Value;
        }
    }
