namespace SportApp.ProductsServices.Infrastructure.EntityFramework.ProductService.Repositories ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Repositories;
using Microsoft.EntityFrameworkCore;

    public class ProductServiceRepository([NotNull] ProductServiceContext context) : IProductServiceRepository
    {
        public async Task SaveAndPublishAsync(ProductService productService)
        {
            if (productService.State is EntityState.Added)
            {
                await context.ProductServices.AddAsync(productService);
            }
            else
            {
                context.ProductServices.Attach(productService);
            }
            await context.SaveChangesAsync();
        }

        public async Task<ProductService?> GetByIdAsync(Guid id)
        {
            var query = context.ProductServices.AsQueryable();
            query.Where(x => x.Enabled && x.Id == id);
            var productService = await query.FirstOrDefaultAsync();
            if (productService != null)
            {
                await context.Entry(productService).Reference(x => x.Plan).LoadAsync();
                await context.Entry(productService).Reference(x => x.GeographicInfo).LoadAsync();
                await context.Entry(productService).Reference(x => x.TypeOfNutrition).LoadAsync();
                await context.Entry(productService).Reference(x => x.ServiceType).Query().Include(c => c.Category).LoadAsync();
            }
            return productService;
        }

        public async Task<ICollection<ProductService>> GetAllActiveAsync()
        {
            return await context.ProductServices.Where(x => x.Enabled).ToListAsync();
        }
    }
