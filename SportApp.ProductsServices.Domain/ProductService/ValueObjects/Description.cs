namespace SportApp.ProductsServices.Domain.ProductService.ValueObjects ;
using Common;
using Common.Exceptions;

    public class Description : StringValueObject
    {
        private const short ValueMaxLength = 50;

        public Description(string value) : base(value)
        {
            if (Value.Length > ValueMaxLength)
            {
                throw new DescriptionMaxLengthException();
            }
        }

        public static implicit operator Description(string value)
        {
            return new Description(value);
        }

        public static implicit operator string(Description description)
        {
            return description != null ? description.Value : string.Empty;
        }
    }
