namespace SportApp.ProductsServices.Api.Controllers.UseCase.Activity.GetAllActiveActivities ;
using Domain.Activities;

    public class ResponseGetAllActivities
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public static ICollection<ResponseGetAllActivities> MapResponse(ICollection<Activity> activities)
        {
            return new List<ResponseGetAllActivities>(activities.Select(x => new ResponseGetAllActivities
            {
                Id = x.Id,
                Name = x.Name.ToString()
            }));
        }
    }
