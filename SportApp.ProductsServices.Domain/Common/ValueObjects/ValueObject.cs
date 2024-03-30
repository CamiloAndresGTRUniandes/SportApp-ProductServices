namespace SportApp.ProductsServices.Domain.Common ;

using System.Reflection;

//this base class comes from Jimmy Bogard
//http://grabbagoft.blogspot.com/2007/06/generic-value-object-equality.html

    /// <summary>
    /// class value object implementation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ValueObject<T> : IEquatable<T>
        where T : ValueObject<T>
    {
        public virtual bool Equals(T other)
        {
            if (other == null)
            {
                return false;
            }

            var t = GetType();
            var otherType = other.GetType();

            if (t != otherType)
            {
                return false;
            }

            var fields = t.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var field in fields)
            {
                var value1 = field.GetValue(other);
                var value2 = field.GetValue(this);

                if (value1 != null)
                {
                    if (!value1.Equals(value2))
                    {
                        return false;
                    }
                }
                else
                {
                    if (value2 != null)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var other = obj as T;

            return Equals(other);
        }

        public override int GetHashCode()
        {
            var fields = GetFields();

            var startValue = 17;
            var multiplier = 59;

            return fields.Select(field => field.GetValue(this)).Where(value => value != null)
                .Aggregate(startValue, (current, value) => current * multiplier + value.GetHashCode());
        }

        private IEnumerable<FieldInfo> GetFields()
        {
            var t = GetType();

            var fields = new List<FieldInfo>();

            while (t != typeof(object))
            {
                fields.AddRange(t.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public));

                t = t.BaseType;
            }

            return fields;
        }

        public static bool operator ==(ValueObject<T> x, ValueObject<T> y)
        {
            if (ReferenceEquals(x, null) ^ ReferenceEquals(y, null))
            {
                return false;
            }

            return ReferenceEquals(x, null) || x.Equals(y);
        }

        public static bool operator !=(ValueObject<T> x, ValueObject<T> y)
        {
            return !(x == y);
        }
    }
