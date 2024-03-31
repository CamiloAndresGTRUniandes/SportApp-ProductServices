namespace SportApp.ProductsServices.Domain.Common.ValueObjects ;

    public class IntValueObject : IComparable
    {
        protected IntValueObject(int value)
        {
            Value = value;
        }

        private protected int Value { get; }

        public int CompareTo(object obj)
        {
            return obj == null ? -1 : Value.CompareTo(((IntValueObject)obj).Value);
        }

        public static bool operator ==(IntValueObject x, IntValueObject y)
        {
            return EqualOperator(x, y);
        }

        public static bool operator !=(IntValueObject x, IntValueObject y)
        {
            return !(x == y);
        }

        private static bool EqualOperator(IntValueObject left, IntValueObject right)
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

            var other = (IntValueObject)obj;
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
            return $"{Value}";
        }

        public static bool operator <(IntValueObject left, IntValueObject right)
        {
            return ReferenceEquals(left, null) ? !ReferenceEquals(right, null) : left.CompareTo(right) < 0;
        }

        public static bool operator <=(IntValueObject left, IntValueObject right)
        {
            return ReferenceEquals(left, null) || left.CompareTo(right) <= 0;
        }

        public static bool operator >(IntValueObject left, IntValueObject right)
        {
            return !ReferenceEquals(left, null) && left.CompareTo(right) > 0;
        }

        public static bool operator >=(IntValueObject left, IntValueObject right)
        {
            return ReferenceEquals(left, null) ? ReferenceEquals(right, null) : left.CompareTo(right) >= 0;
        }
    }
