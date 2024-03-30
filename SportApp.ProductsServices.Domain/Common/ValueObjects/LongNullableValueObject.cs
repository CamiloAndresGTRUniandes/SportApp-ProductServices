namespace SportApp.ProductsServices.Domain.Common.ValueObjects ;

    public class LongNullableValueObject(long? value) : IComparable<LongNullableValueObject>
    {
        private readonly long? _value = value;

        public long? Value => _value;

        public int CompareTo(LongNullableValueObject other)
        {
            if (other == null || !_value.HasValue)
            {
                if (!_value.HasValue && other?._value.HasValue == true)
                {
                    return -1;
                }

                return 0;
            }

            return _value?.CompareTo(other._value) ?? -1;
        }

        public static bool operator <(LongNullableValueObject left, LongNullableValueObject right)
        {
            if (left is null && right is null)
            {
                return false;
            }

            return left != null && left.CompareTo(right) < 0;
        }

        public static bool operator >(LongNullableValueObject left, LongNullableValueObject right)
        {
            if (left is null && right is null)
            {
                return false;
            }

            return left != null && left.CompareTo(right) > 0;
        }

        public static bool operator <=(LongNullableValueObject left, LongNullableValueObject right)
        {
            if (left is null && right is null)
            {
                return true;
            }

            return left!.CompareTo(right) <= 0;
        }

        public static bool operator >=(LongNullableValueObject left, LongNullableValueObject right)
        {
            if (left is null && right is null)
            {
                return true;
            }

            return left != null && left.CompareTo(right) >= 0;
        }

        public static bool operator ==(LongNullableValueObject left, LongNullableValueObject right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (left is null || right is null)
            {
                return false;
            }

            return left.Equals(right);
        }

        public static bool operator !=(LongNullableValueObject left, LongNullableValueObject right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() != GetType())
            {
                return false;
            }

            var rhs = (LongNullableValueObject)obj;

            return rhs != null && _value == rhs._value;
        }

        public override int GetHashCode()
        {
            return _value?.GetHashCode() ?? 0;
        }
    }
