namespace SportApp.ProductsServices.Application.Recommendation.Interfaces ;
using Domain.Recommendations.DTO;

    public interface IUsersService
    {
        Task<ICollection<UserProfileDto>> GetUsersAsync(GetUsersFiltersQuery query);
    }
