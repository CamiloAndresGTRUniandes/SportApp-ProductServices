namespace SportApp.ProductsServices.Domain.Common.ValueObjects ;
using Exceptions;

    public class Name : StringValueObject
    {
        private const short ValueMaxLength = 50;

        public Name(string value) : base(value)
        {
            if (Value.Length > ValueMaxLength)
            {
                throw new NameMaxLengthException();
            }
        }

        public static implicit operator Name(string value)
        {
            return new Name(value);
        }

        public static implicit operator string(Name value)
        {
            return value != null ? value.Value : string.Empty;
        }
    }
