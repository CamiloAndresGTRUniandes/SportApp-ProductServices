namespace SportApp.ProductsServices.Infrastructure.EntityFramework.ProductService.Repositories ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Repositories;
using Microsoft.EntityFrameworkCore;

    public class ServiceTypeRepository([NotNull] ProductServiceContext context) : IServiceTypeRepository
    {
        public async Task SaveAndPublishAsync(ServiceType serviceType)
        {
            if (serviceType.State is EntityState.Added)
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
    }
