namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Activity.Repositories ;
using System.Diagnostics.CodeAnalysis;
using Domain.Activities;
using Domain.Activities.Repositories;
using Domain.Common.ValueObjects;
using Microsoft.EntityFrameworkCore;

    public class ActivityRepository([NotNull] ProductServiceContext context) : IActivityRepository
    {
        public async Task SaveAndPublishAsync(Activity activity)
        {
            if (activity.EntityState is EntityState.Added)
            {
                await context.Activities.AddAsync(activity);
            }
            else
            {
                context.Activities.Attach(activity);
            }
            await context.SaveChangesAsync();
        }

        public async Task<Activity?> GetByIdAsync(Guid id)
        {
            var query = context.Activities.AsQueryable();
            var activity = await query.FirstOrDefaultAsync(x => x.Enabled && x.Id == id);

            return activity;
        }

        public async Task<ICollection<Activity>> GetAllActiveAsync()
        {
            var query = context.Activities.AsQueryable();
            var activities = await query.Where(a => a.Enabled).ToListAsync();
            return activities;
        }

        public async Task<Activity?> GetByNameAsync(Name name)
        {
            var query = context.Activities.AsQueryable();
            var activity = await query.FirstOrDefaultAsync(x => x.Name.Equals(name));

            return activity;
        }
    }
