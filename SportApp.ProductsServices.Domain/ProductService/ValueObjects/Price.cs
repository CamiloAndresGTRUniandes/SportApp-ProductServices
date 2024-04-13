namespace SportApp.ProductsServices.Domain.ProductService.ValueObjects ;
using Common.ValueObjects;

    public class Price(long? value) : LongNullableValueObject(value)
    {
        public static implicit operator Price(long? size)
        {
            return new Price(size);
        }

        public static implicit operator long?(Price size)
        {
            return size?.Value;
        }
    }
