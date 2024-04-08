namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Goal.Repositories ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.ValueObjects;
using Domain.Goals;
using Domain.Goals.Repositories;
using Microsoft.EntityFrameworkCore;

    public class GoalRepository([NotNull] ProductServiceContext context) : IGoalRepository
    {
        public async Task SaveAndPublishAsync(Goal goal)
        {
            if (goal.EntityState is EntityState.Added)
            {
                await context.Goals.AddAsync(goal);
            }
            else
            {
                context.Goals.Attach(goal);
            }
            await context.SaveChangesAsync();
        }

        public async Task<ICollection<Goal>> GetAllActiveAsync()
        {
            var query = context.Goals.AsQueryable();
            var goals = await query.Where(a => a.Enabled).ToListAsync();
            return goals;
        }

        public async Task<Goal?> GetByIdAsync(Guid id)
        {
            var query = context.Goals.AsQueryable();
            var goal = await query.FirstOrDefaultAsync(x => x.Enabled && x.Id == id);

            return goal;
        }

        public async Task<Goal?> GetByNameAsync(Name name)
        {
            var query = context.Goals.AsQueryable();
            var goal = await query.FirstOrDefaultAsync(x => x.Name.Equals(name));

            return goal;
        }
    }
