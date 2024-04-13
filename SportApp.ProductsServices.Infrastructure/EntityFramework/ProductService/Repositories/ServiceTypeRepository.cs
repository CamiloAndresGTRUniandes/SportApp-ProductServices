namespace SportApp.ProductsServices.Infrastructure.EntityFramework.ProductService.Repositories ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Repositories;
using Microsoft.EntityFrameworkCore;

    public class ServiceTypeRepository([NotNull] ProductServiceContext context) : IServiceTypeRepository
    {
        public async Task SaveAndPublishAsync(ServiceType serviceType)
        {
            if (serviceType.EntityState is EntityState.Added)
            {
                await context.ServiceType.AddAsync(serviceType);
            }
            else
            {
                context.ServiceType.Attach(serviceType);
            }
            await context.SaveChangesAsync();
        }

        public async Task<ServiceType?> GetByIdAsync(Guid id)
        {
            var query = context.ServiceType.AsQueryable();
            var serviceType = await query.FirstOrDefaultAsync(x => x.Enabled && x.Id == id);

            return serviceType;
        }

        public async Task<ICollection<ServiceType>> GetAllActiveAsync()
        {
            var query = context.ServiceType.AsQueryable();
            query = query.Where(x => x.Enabled);
            var serviceTypes = await query.ToListAsync();
            foreach (var serviceType in serviceTypes)
            {
                await context.Entry(serviceType).Reference(x => x.Category).LoadAsync();
            }
            return serviceTypes;
        }

        public async Task<Category?> GetAllActiveServiceTypesByCategoryAsync(Guid id)
        {
            var query = context.Categories.AsQueryable();
            query = query.Where(x => x.Enabled && x.Id == id);
            var category = await query.FirstOrDefaultAsync();
            if (category != null)
            {
                //await context.Entry(country).Reference(x => x.State).LoadAsync();
                await context.Entry(category).Collection(p => p.ServiceType).LoadAsync();
            }
            return category;
        }
    }
