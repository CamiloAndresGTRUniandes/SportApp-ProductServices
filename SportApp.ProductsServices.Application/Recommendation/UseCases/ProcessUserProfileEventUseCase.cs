namespace SportApp.ProductsServices.Application.Recommendation.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Bus;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Domain.ProductService.Repositories;
using Domain.Recommendations;
using Domain.Recommendations.Repositories;
using Events;
using Interfaces;

    public class ProcessUserProfileEventUseCase(
        [NotNull] IProductServiceRepository productServiceRepository,
        [NotNull] IEventBus bus,
        [NotNull] IRecommendationRepository recommendationRepository) : IProcessUserProfileEvent
    {
        private readonly Guid EventsCategoryId = Guid.Parse("BE8E2306-8BC9-49CC-8D43-A76820370994");
        private readonly Guid NutritionalPlansServiceTypeId = Guid.Parse("01B50F0D-3226-4DF2-B912-4DA4B37D9BD9");
        private readonly Guid TrainingPlansServiceTypeId = Guid.Parse("3040214a-a77d-4549-8f67-6b51f7755a3e");

        public async ValueTask ExecuteAsync(UserProfileEventBus @event)
        {
            var recommendations = new List<Recommendation>();
            var events = await GetEventsAsync(@event);
            var nutritionalPlans = await GetNutritionalPlansAsync(@event);
            var trainingPlans = await GetTrainingPlansAsync(@event);
            recommendations
                .AddRange(events
                    .Select(x =>
                        Recommendation.Build(Guid.NewGuid(), Guid.Parse(@event.UserId), x)).ToList());
            recommendations
                .AddRange(nutritionalPlans
                    .Select(x =>
                        Recommendation.Build(Guid.NewGuid(), Guid.Parse(@event.UserId), x)).ToList());
            recommendations
                .AddRange(trainingPlans
                    .Select(x =>
                        Recommendation.Build(Guid.NewGuid(), Guid.Parse(@event.UserId), x)).ToList());
            foreach (var recommendation in recommendations)
            {
                await bus.PublishAsync(
                    new EventsUsersEventBus
                    {
                        Title = recommendation.ProductService.Name.ToString(),
                        Description = recommendation.ProductService.Description.ToString(),
                        Type = "Suggestion",
                        UserId = recommendation.User.ToString()
                    });
            }
            await recommendationRepository.SaveAndPublishAsync(recommendations);
        }

        private async Task<IEnumerable<ProductService>> GetEventsAsync(UserProfileEventBus @event)
        {
            var parameters = new GetProductServiceCommand
            {
                Categories = new List<Guid> { EventsCategoryId },
                Activities = @event.Activities,
                Goals = @event.Goals,
                StartDateTime = DateTime.Now.Date,
                EndDateTime = DateTime.Now.Date
            };
            var events = await productServiceRepository.GetAllWithParametersAsync(parameters);
            events =
                events.Where(
                    x =>
                        x.GeographicInfo!.CountryId == @event.CountryId && x.GeographicInfo.StateId == @event.StateId &&
                        x.GeographicInfo.CityId == @event.CityId).ToList();
            return events;
        }

        private async Task<IEnumerable<ProductService>> GetNutritionalPlansAsync(UserProfileEventBus @event)
        {
            var parameters = new GetProductServiceCommand
            {
                ServiceTypes = new List<Guid> { NutritionalPlansServiceTypeId },
                Activities = @event.Activities,
                Goals = @event.Goals,
                TypesOfNutrition = new List<Guid> { @event.NutrionalProfile.TypeOfNutritionId },
                Allergies = @event.NutricionalAllergies
            };
            var nutritionalPlans = await productServiceRepository.GetAllWithParametersAsync(parameters);
            return nutritionalPlans;
        }

        private async Task<IEnumerable<ProductService>> GetTrainingPlansAsync(UserProfileEventBus @event)
        {
            var parameters = new GetProductServiceCommand
            {
                ServiceTypes = new List<Guid> { TrainingPlansServiceTypeId },
                Activities = @event.Activities,
                Goals = @event.Goals
            };
            var nutritionalPlans = await productServiceRepository.GetAllWithParametersAsync(parameters);
            nutritionalPlans = nutritionalPlans.Where(x => @event.Age >= x.TrainingPlan!.StartAge && @event.Age <= x.TrainingPlan!.EndAge).ToList();
            return nutritionalPlans;
        }
    }
