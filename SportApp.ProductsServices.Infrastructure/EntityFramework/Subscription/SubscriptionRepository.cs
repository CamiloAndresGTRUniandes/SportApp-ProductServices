namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Subscription ;
using System.Diagnostics.CodeAnalysis;
using Domain.Subscription;
using Domain.Subscription.Repositories;
using Microsoft.EntityFrameworkCore;

    public class SubscriptionRepository([NotNull] ProductServiceContext context) : ISubscriptionRepository
    {
        public async Task SaveAndPublishAsync(Subscription subscription)
        {
            if (subscription.EntityState is EntityState.Added)
            {
                await context.Subscriptions.AddAsync(subscription);
            }
            else
            {
                context.Subscriptions.Attach(subscription);
            }
            await context.SaveChangesAsync();
        }

        public async Task<bool> GetActiveByUserIdAsync(Guid id, DateTime startDate, DateTime endDate)
        {
            var query = context.Subscriptions.AsQueryable();
            var subscription = await query.AnyAsync(x =>
                x.Enabled &&
                x.User == id &&
                startDate <= x.EndDate);
            //((startDate >= x.StartDate && startDate <= x.EndDate) ||
            // (endDate >= x.StartDate && endDate <= x.EndDate) ||
            // (startDate <= x.StartDate && endDate >= x.EndDate)));

            return subscription;
        }
    }
