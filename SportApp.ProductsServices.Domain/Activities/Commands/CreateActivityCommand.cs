namespace SportApp.ProductsServices.Domain.Activities.Commands ;
using Common.Commands;
using Common.ValueObjects;

    public class CreateActivityCommand : IDomainRequest<Activity>
    {
        public Guid Id { get; set; }
        public Name Name { get; set; }
        public Guid User { get; set; }
    }
