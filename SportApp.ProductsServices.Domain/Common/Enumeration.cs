namespace SportApp.ProductsServices.Domain.Common ;

using System.Reflection;
using Exceptions;

    /// <summary>
    /// Enumeration class
    /// <inheritdoc>
    ///     <see
    ///         cref="https://docs.microsoft.com/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/enumeration-classes-over-enum-types" />
    /// </inheritdoc>
    /// </summary>
    public class Enumeration : IComparable<Enumeration>
    {
        protected Enumeration(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; }

        public int Id { get; }

        public int CompareTo(Enumeration other)
        {
            if (other == null)
            {
                return -1;
            }

            return string.Compare(Name, other.Name, StringComparison.Ordinal) != 0
                ? string.Compare(Name, other.Name, StringComparison.Ordinal)
                : 0;
        }

        public override string ToString()
        {
            return Name;
        }

        public static bool operator <(Enumeration left, Enumeration right)
        {
            return ReferenceEquals(left, null) ? !ReferenceEquals(right, null) : left.CompareTo(right) < 0;
        }

        public static bool operator <=(Enumeration left, Enumeration right)
        {
            return ReferenceEquals(left, null) || left.CompareTo(right) <= 0;
        }

        public static bool operator >(Enumeration left, Enumeration right)
        {
            return !ReferenceEquals(left, null) && left.CompareTo(right) > 0;
        }

        public static bool operator >=(Enumeration left, Enumeration right)
        {
            return ReferenceEquals(left, null) ? ReferenceEquals(right, null) : left.CompareTo(right) >= 0;
        }

        public static bool operator ==(Enumeration x, Enumeration y)
        {
            return EqualOperator(x, y);
        }

        private static bool EqualOperator(Enumeration left, Enumeration right)
        {
            if (ReferenceEquals(left, null) ^ ReferenceEquals(right, null))
            {
                return false;
            }

            return ReferenceEquals(left, null) || left.Equals(right);
        }

        public static bool operator !=(Enumeration x, Enumeration y)
        {
            return !(x == y);
        }

        private static IEnumerable<T> GetAll<T>() where T : Enumeration
        {
            var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            return fields.Select(f => f.GetValue(null)).Cast<T>();
        }

        public override bool Equals(object obj)
        {
            var otherValue = obj as Enumeration;

            if (otherValue == null)
            {
                return false;
            }

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Id.Equals(otherValue.Id);

            return typeMatches && valueMatches;
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public static T FromValue<T>(int value) where T : Enumeration
        {
            var matchingItem = Parse<T, int>(value, "value", item => item.Id == value);
            return matchingItem;
        }

        public static T FromDisplayName<T>(string displayName) where T : Enumeration
        {
            var matchingItem = Parse<T, string>(displayName, "display name",
                item => item.Name.Equals(displayName, StringComparison.InvariantCultureIgnoreCase));
            return matchingItem;
        }

        private static T Parse<T, K>(K value, string description, Func<T, bool> predicate) where T : Enumeration
        {
            var matchingItem = GetAll<T>().FirstOrDefault(predicate);

            if (matchingItem == null)
            {
                throw new InvalidDisplayNameException(value.ToString(), description, typeof(T));
            }

            return matchingItem;
        }

        public static T ToEnumerator<T>(string displayName, T defaultValue) where T : Enumeration
        {
            var matchingItem = TryParse(
                item => item.Name.Equals(displayName, StringComparison.InvariantCultureIgnoreCase), defaultValue);
            return matchingItem;
        }

        private static T TryParse<T>(Func<T, bool> predicate, T defaultValue) where T : Enumeration
        {
            var matchingItem = GetAll<T>().FirstOrDefault(predicate);
            return matchingItem ?? defaultValue;
        }
    }
