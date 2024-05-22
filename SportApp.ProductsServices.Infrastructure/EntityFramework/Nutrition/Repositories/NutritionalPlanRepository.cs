namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Nutrition.Repositories ;
using System.Diagnostics.CodeAnalysis;
using Domain.Nutrition;
using Domain.Nutrition.Repositories;
using Microsoft.EntityFrameworkCore;

    public class NutritionalPlanRepository([NotNull] ProductServiceContext context) : INutritionalPlanRepository
    {
        public async Task SaveAndPublishAsync(NutritionalPlan nutritionalPlan)
        {
            if (nutritionalPlan.EntityState is EntityState.Added)
            {
                await context.NutritionalPlans.AddAsync(nutritionalPlan);
            }
            else
            {
                context.NutritionalPlans.Attach(nutritionalPlan);
            }
            await context.SaveChangesAsync();
        }

        public async Task<NutritionalPlan?> GetByIdAsync(Guid id)
        {
            var query = context.NutritionalPlans.AsQueryable();
            var category = await query.FirstOrDefaultAsync(x => x.Enabled && x.Id == id);

            return category;
        }
    }
