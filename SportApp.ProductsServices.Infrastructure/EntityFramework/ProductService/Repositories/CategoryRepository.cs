namespace SportApp.ProductsServices.Infrastructure.EntityFramework.ProductService.Repositories ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.ValueObjects;
using Domain.ProductService;
using Domain.ProductService.Repositories;
using Microsoft.EntityFrameworkCore;

    public class CategoryRepository([NotNull] ProductServiceContext context) : ICategoryRepository
    {
        public async Task SaveAndPublishAsync(Category category)
        {
            if (category.EntityState is EntityState.Added)
            {
                await context.Categories.AddAsync(category);
            }
            else
            {
                context.Categories.Attach(category);
            }
            await context.SaveChangesAsync();
        }

        public async Task<ICollection<Category>> GetAllActiveAsync()
        {
            var query = context.Categories.AsQueryable();
            var categories = await query.Where(a => a.Enabled).ToListAsync();
            return categories;
        }

        public async Task<Category?> GetByIdAsync(Guid id)
        {
            var query = context.Categories.AsQueryable();
            var category = await query.FirstOrDefaultAsync(x => x.Enabled && x.Id == id);

            return category;
        }

        public async Task<Category?> GetByNameAsync(Name name)
        {
            var query = context.Categories.AsQueryable();
            var category = await query.FirstOrDefaultAsync(x => x.Name.Equals(name));

            return category;
        }
    }
