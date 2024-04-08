namespace SportApp.ProductsServices.Infrastructure.EntityFramework.ProductService.Repositories ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Repositories;
using Microsoft.EntityFrameworkCore;

    public class PlanRepository([NotNull] ProductServiceContext context) : IPlanRepository
    {
        public async Task SaveAndPublishAsync(Plan plan)
        {
            if (plan.EntityState is EntityState.Added)
            {
                await context.Plans.AddAsync(plan);
            }
            else
            {
                context.Plans.Attach(plan);
            }
            await context.SaveChangesAsync();
        }

        public async Task<Plan?> GetByIdAsync(Guid id)
        {
            var query = context.Plans.AsQueryable();
            var plan = await query.FirstOrDefaultAsync(x => x.Enabled && x.Id == id);

            return plan;
        }

        public async Task<ICollection<Plan>> GetAllActiveAsync()
        {
            var query = context.Plans.AsQueryable();
            query = query.Where(x => x.Enabled);
            var plans = await query.ToListAsync();

            return plans;
        }
    }
