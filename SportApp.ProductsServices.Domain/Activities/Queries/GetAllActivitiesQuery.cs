namespace SportApp.ProductsServices.Domain.Activities.Queries ;
using Common.Commands;

    public class GetAllActivitiesQuery : IDomainRequest<ICollection<Activity>>
    {
    }
