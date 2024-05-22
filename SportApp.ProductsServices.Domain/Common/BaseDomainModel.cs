namespace SportApp.ProductsServices.Domain.Common ;
using System.ComponentModel.DataAnnotations.Schema;
using Events;

    public class BaseDomainModel : ObjectWithState, IComparable
    {
        private readonly List<Event> _domainMessages = new();

        protected BaseDomainModel()
        {
        }

        protected BaseDomainModel(
            Guid id,
            DateTime createdAt,
            DateTime updatedAt,
            Guid? createdBy,
            Guid? updatedBy,
            bool enabled) : this()
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedBy = updatedBy;
            CreatedBy = createdBy;
            UpdatedAt = updatedAt;
            Enabled = enabled;
        }

        [NotMapped]
        public IReadOnlyList<Event> DomainMessages => _domainMessages;

        public Guid Id { get; init; }

        public DateTime CreatedAt { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime UpdatedAt { get; set; }

        public Guid? UpdatedBy { get; set; }

        public bool Enabled { get; set; }

        public int CompareTo(object? obj)
        {
            return obj == null ? -1 : Id.CompareTo(((BaseDomainModel)obj).Id);
        }

        internal void RaiseDomainEvent(Event domainEvent)
        {
            _domainMessages.Add(domainEvent);
        }

        internal void InsertAtFirst(Event domainEvent)
        {
            _domainMessages.Insert(0, domainEvent);
        }

        internal void RemoveDomainEvent(Event domainEvent)
        {
            _domainMessages.Remove(domainEvent);
        }

        public void ClearDomainEvents()
        {
            SetUnchanged();
            _domainMessages.Clear();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is BaseDomainModel other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (GetRealType() != other.GetRealType())
            {
                return false;
            }

            if (Id == Guid.Empty || other.Id == Guid.Empty)
            {
                return false;
            }

            return Id == other.Id;
        }

        public static bool operator ==(BaseDomainModel x, BaseDomainModel y)
        {
            return EqualOperator(x, y);
        }

        public static bool operator !=(BaseDomainModel x, BaseDomainModel y)
        {
            return !(x == y);
        }

        public static bool operator <(BaseDomainModel left, BaseDomainModel right)
        {
            return ReferenceEquals(left, null) ? !ReferenceEquals(right, null) : left.CompareTo(right) < 0;
        }

        public static bool operator <=(BaseDomainModel left, BaseDomainModel right)
        {
            return ReferenceEquals(left, null) || left.CompareTo(right) <= 0;
        }

        public static bool operator >(BaseDomainModel left, BaseDomainModel right)
        {
            return !ReferenceEquals(left, null) && left.CompareTo(right) > 0;
        }

        public static bool operator >=(BaseDomainModel left, BaseDomainModel right)
        {
            return ReferenceEquals(left, null) ? ReferenceEquals(right, null) : left.CompareTo(right) >= 0;
        }

        private static bool EqualOperator(BaseDomainModel left, BaseDomainModel right)
        {
            if (ReferenceEquals(left, null) ^ ReferenceEquals(right, null))
            {
                return false;
            }

            return ReferenceEquals(left, null) || left.Equals(right);
        }

        public override int GetHashCode()
        {
            return (GetRealType().ToString() + Id).GetHashCode();
        }

        private Type GetRealType()
        {
            var type = GetType();
            if (type.ToString().Contains("Castle.Proxies.", StringComparison.CurrentCultureIgnoreCase))
            {
                return type.BaseType;
            }

            return type;
        }
    }
