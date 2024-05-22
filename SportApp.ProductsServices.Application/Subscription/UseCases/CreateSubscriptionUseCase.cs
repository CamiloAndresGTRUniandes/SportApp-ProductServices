namespace SportApp.ProductsServices.Application.Subscription.UseCases ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService.Repositories;
using Domain.Subscription;
using Domain.Subscription.Commands;
using Domain.Subscription.Repositories;
using Exceptions;
using Interfaces;
using ProductService.Exceptions;

    public class CreateSubscriptionUseCase(
        [NotNull] ISubscriptionRepository subscriptionRepository,
        [NotNull] IPlanRepository planRepository) : ICreateSubscription
    {
        private readonly Guid BasicPlanId = Guid.Parse("672D4087-AC82-42B5-846E-64905D1A09B3");
        private readonly Guid IntermediatePlanId = Guid.Parse("2C312559-173D-4239-A03D-2FDB3F219FA5");
        private readonly Guid PremiumPlanId = Guid.Parse("7EE7DB76-77C2-4353-A509-EBE4FBE4AED4");

        public async ValueTask<Subscription> ExecuteAsync(CreateSubscriptionCommand request)
        {
            var plan = await planRepository.GetByIdAsync(request.PlanId) ?? throw new PlanNotFoundConflictException(request.PlanId);
            var existingSubscription = await subscriptionRepository.GetActiveByUserIdAsync(request.User, request.StartDate, request.EndDate);
            if (existingSubscription != null)
            {
                if (existingSubscription.Plan.Id == plan.Id)
                {
                    throw new ExistingSubscriptionConflictException(request.User);
                }
                if (plan.Id == BasicPlanId || (plan.Id == IntermediatePlanId && existingSubscription.Plan.Id == PremiumPlanId))
                {
                    throw new DowngradeSubscriptionConflictException(request.User);
                }
            }
            var subscription = Subscription.Build(request.Id, request.StartDate, request.EndDate, request.User, plan);
            await subscriptionRepository.SaveAndPublishAsync(subscription);
            return subscription;
        }
    }
