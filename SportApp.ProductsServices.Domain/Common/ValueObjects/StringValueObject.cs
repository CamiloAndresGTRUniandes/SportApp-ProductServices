namespace SportApp.ProductsServices.Domain.Common ;

    public class StringValueObject : IComparable
    {
        public static readonly string ValueName = nameof(Value);

        protected StringValueObject(string value)
        {
            Value = string.IsNullOrWhiteSpace(value) ? string.Empty : value.Trim();
        }

        private protected string Value { get; set; }

        public int CompareTo(object obj)
        {
            return obj == null ? -1 : string.Compare(Value, ((StringValueObject)obj).Value, StringComparison.Ordinal);
        }

        public static bool operator ==(StringValueObject x, StringValueObject y)
        {
            return EqualOperator(x, y);
        }

        public static bool operator !=(StringValueObject x, StringValueObject y)
        {
            return !(x == y);
        }

        private static bool EqualOperator(StringValueObject left, StringValueObject right)
        {
            if (ReferenceEquals(left, null) ^ ReferenceEquals(right, null))
            {
                return false;
            }

            return ReferenceEquals(left, null) || left.Equals(right);
        }

        private IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            var other = (StringValueObject)obj;
            var thisValues = GetAtomicValues().GetEnumerator();
            var otherValues = other.GetAtomicValues().GetEnumerator();
            while (thisValues.MoveNext() && otherValues.MoveNext())
            {
                if (ReferenceEquals(thisValues.Current, null) ^
                    ReferenceEquals(otherValues.Current, null))
                {
                    return false;
                }

                if (thisValues.Current != null &&
                    !thisValues.Current.Equals(otherValues.Current))
                {
                    return false;
                }
            }

            return !thisValues.MoveNext() && !otherValues.MoveNext();
        }

        public override int GetHashCode()
        {
            return GetAtomicValues()
                .Select(x => x != null ? x.GetHashCode() : 0)
                .Aggregate((x, y) => x ^ y);
        }

        public override string ToString()
        {
            return !string.IsNullOrWhiteSpace(Value) ? Value : "";
        }

        public static bool operator <(StringValueObject left, StringValueObject right)
        {
            return ReferenceEquals(left, null) ? !ReferenceEquals(right, null) : left.CompareTo(right) < 0;
        }

        public static bool operator <=(StringValueObject left, StringValueObject right)
        {
            return ReferenceEquals(left, null) || left.CompareTo(right) <= 0;
        }

        public static bool operator >(StringValueObject left, StringValueObject right)
        {
            return !ReferenceEquals(left, null) && left.CompareTo(right) > 0;
        }

        public static bool operator >=(StringValueObject left, StringValueObject right)
        {
            return ReferenceEquals(left, null) ? ReferenceEquals(right, null) : left.CompareTo(right) >= 0;
        }
    }
