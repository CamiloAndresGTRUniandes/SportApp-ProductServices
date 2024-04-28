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

        public async Task<Subscription?> GetByUserIdAsync(Guid id)
        {
            var query = context.Subscriptions.AsQueryable();
            var subscription = await query.FirstOrDefaultAsync(x => x.Enabled && x.User == id);

            return subscription;
        }
    }
