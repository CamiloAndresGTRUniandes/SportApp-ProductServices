namespace SportApp.ProductsServices.Domain.Common ;
using Microsoft.EntityFrameworkCore;

    public class ObjectWithState
    {
        protected ObjectWithState()
        {
            EntityState = EntityState.Unchanged;
        }

        public EntityState EntityState { get; private set; }

        private protected void SetModifiedIfNotAdded()
        {
            if (EntityState != EntityState.Added)
            {
                EntityState = EntityState.Modified;
            }
        }

        private protected void SetAdded()
        {
            EntityState = EntityState.Added;
        }

        private protected void SetDeleted()
        {
            EntityState = EntityState.Deleted;
        }

        private protected void SetUnchanged()
        {
            EntityState = EntityState.Unchanged;
        }

        private protected void SetModified()
        {
            EntityState = EntityState.Modified;
        }
    }
