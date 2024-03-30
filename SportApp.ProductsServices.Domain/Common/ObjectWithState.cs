namespace SportApp.ProductsServices.Domain.Common ;
using Microsoft.EntityFrameworkCore;

    public class ObjectWithState
    {
        protected ObjectWithState()
        {
            State = EntityState.Unchanged;
        }

        public EntityState State { get; private set; }

        private protected void SetModifiedIfNotAdded()
        {
            if (State != EntityState.Added)
            {
                State = EntityState.Modified;
            }
        }

        private protected void SetAdded()
        {
            State = EntityState.Added;
        }

        private protected void SetDeleted()
        {
            State = EntityState.Deleted;
        }

        private protected void SetUnchanged()
        {
            State = EntityState.Unchanged;
        }

        private protected void SetModified()
        {
            State = EntityState.Modified;
        }
    }
