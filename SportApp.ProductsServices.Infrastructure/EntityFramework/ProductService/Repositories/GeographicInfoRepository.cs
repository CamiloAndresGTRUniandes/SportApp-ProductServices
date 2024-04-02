namespace SportApp.ProductsServices.Infrastructure.EntityFramework.ProductService.Repositories ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Repositories;
using Microsoft.EntityFrameworkCore;

    public class GeographicInfoRepository([NotNull] ProductServiceContext context) : IGeographicInfoRepository
    {
        public async Task SaveAndPublishAsync(GeographicInfo geographicInfo)
        {
            if (geographicInfo.State is EntityState.Added)
            {
                await context.GeographicInfo.AddAsync(geographicInfo);
            }
            else
            {
                context.GeographicInfo.Attach(geographicInfo);
            }
            await context.SaveChangesAsync();
        }

        public async Task<GeographicInfo?> GetByIdAsync(Guid id)
        {
            var query = context.GeographicInfo.AsQueryable();
            var geographicInfo = await query.FirstOrDefaultAsync(x => x.Enabled && x.Id == id);

            return geographicInfo;
        }
    }
