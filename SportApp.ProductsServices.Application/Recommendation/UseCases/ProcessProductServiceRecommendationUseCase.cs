namespace SportApp.ProductsServices.Application.Recommendation.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Bus;
using Domain.ProductService.Events;
using Domain.ProductService.Repositories;
using Domain.Recommendations;
using Domain.Recommendations.DTO;
using Domain.Recommendations.Repositories;
using Events;
using Interfaces;

    public class ProcessProductServiceRecommendationUseCase(
        [NotNull] IUsersService usersService,
        [NotNull] IProductServiceRepository productServiceRepository,
        [NotNull] IEventBus eventBus,
        [NotNull] IRecommendationRepository recommendationRepository) : IProcessProductServiceRecommendation
    {
        public async ValueTask ExecuteAsync(ProductServiceRecommendationCommand @event)
        {
            var product = await productServiceRepository.GetByIdAsync(@event.ProductId);
            if (product is null)
            {
                return;
            }
            var queryParameters = new GetUsersFiltersQuery
            {
                CitiesId = [product.GeographicInfo!.CityId],
                StatesId = [product.GeographicInfo.StateId],
                CountriesId = [product.GeographicInfo.CountryId],
                NutritionalAllergies = product.Allergies().Select(x => x.Id).ToList(),
                Activities = product.Activities().Select(x => x.Id).ToList(),
                Goals = product.Goals().Select(x => x.Id).ToList()
            };
            var users = await usersService.GetUsersAsync(queryParameters);
            foreach (var user in users)
            {
                var recommendation = Recommendation.Build(Guid.NewGuid(), Guid.Parse(user.UserId), product);
                await eventBus.PublishAsync(
                    new EventsUsersEventBus
                    {
                        Title = recommendation.ProductService.Name.ToString(),
                        Description = recommendation.ProductService.Description.ToString(),
                        Type = "Suggestion",
                        UserId = recommendation.User.ToString()
                    });
                await recommendationRepository.SaveAndPublishAsync(recommendation);
            }
        }
    }
