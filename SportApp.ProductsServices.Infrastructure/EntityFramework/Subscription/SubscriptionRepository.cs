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

        public async Task<Subscription> GetActiveByUserIdAsync(Guid id, DateTime startDate, DateTime endDate)
        {
            var query = context.Subscriptions.AsQueryable();
            query = query.Where(x => x.Enabled && x.User == id);
            query = query.Where(c =>
                startDate.Date >= c.StartDate.Date &&
                startDate.Date <= c.EndDate.Date);

            var subscription = await query.FirstOrDefaultAsync();
            if (subscription != null)
            {
                await context.Entry(subscription).Reference(x => x.Plan).LoadAsync();
            }

            return subscription;
        }
    }
