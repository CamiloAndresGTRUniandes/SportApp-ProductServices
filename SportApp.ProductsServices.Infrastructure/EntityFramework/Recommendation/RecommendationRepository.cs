namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Recommendation ;
using System.Diagnostics.CodeAnalysis;
using Domain.Recommendations;
using Domain.Recommendations.Repositories;
using Microsoft.EntityFrameworkCore;

    public class RecommendationRepository([NotNull] ProductServiceContext context) : IRecommendationRepository
    {
        public async Task SaveAndPublishAsync(ICollection<Recommendation> recommendationList)
        {
            foreach (var recommendation in recommendationList)
            {
                if (recommendation.EntityState is EntityState.Added)
                {
                    await context.Recommendations.AddAsync(recommendation);
                }
                else
                {
                    context.Recommendations.Attach(recommendation);
                }
            }
            await context.SaveChangesAsync();
        }

        public async Task<ICollection<Recommendation>> GetAllActiveAsync()
        {
            var query = context.Recommendations.AsQueryable();
            var recommendations = await query.Where(a => a.Enabled).ToListAsync();
            return recommendations;
        }
    }
