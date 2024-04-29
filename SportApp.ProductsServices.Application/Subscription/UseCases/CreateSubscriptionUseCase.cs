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
        public async ValueTask<Subscription> ExecuteAsync(CreateSubscriptionCommand request)
        {
            var plan = await planRepository.GetByIdAsync(request.PlanId) ?? throw new PlanNotFoundConflictException(request.PlanId);
            var existingSubscription = await subscriptionRepository.GetActiveByUserIdAsync(request.Id, request.StartDate, request.EndDate);
            if (existingSubscription)
            {
                throw new ExistingSubscriptionConflictException(request.User);
            }
            var subscription = Subscription.Build(request.Id, request.StartDate, request.EndDate, request.User, plan);
            await subscriptionRepository.SaveAndPublishAsync(subscription);
            return subscription;
        }
    }
