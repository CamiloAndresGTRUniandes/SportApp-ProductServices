namespace SportApp.ProductsServices.Infrastructure.EntityFramework.ProductService.Repositories ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.ValueObjects;
using Domain.ProductService;
using Domain.ProductService.Repositories;
using Microsoft.EntityFrameworkCore;

    public class TypeOfNutritionRepository([NotNull] ProductServiceContext context) : ITypeOfNutritionRepository
    {
        public async Task SaveAndPublishAsync(TypeOfNutrition typeOfNutrition)
        {
            if (typeOfNutrition.EntityState is EntityState.Added)
            {
                await context.TypeOfNutrition.AddAsync(typeOfNutrition);
            }
            else
            {
                context.TypeOfNutrition.Attach(typeOfNutrition);
            }
            await context.SaveChangesAsync();
        }

        public async Task<TypeOfNutrition?> GetByIdAsync(Guid id)
        {
            var query = context.TypeOfNutrition.AsQueryable();
            var typeOfNutrition = await query.FirstOrDefaultAsync(x => x.Enabled && x.Id == id);

            return typeOfNutrition;
        }

        public async Task<ICollection<TypeOfNutrition>> GetAllActiveAsync()
        {
            var query = context.TypeOfNutrition.AsQueryable();
            var typeOfNutritionList = await query.Where(a => a.Enabled).ToListAsync();
            return typeOfNutritionList;
        }

        public async Task<TypeOfNutrition?> GetByNameAsync(Name name)
        {
            var query = context.TypeOfNutrition.AsQueryable();
            var typeOfNutrition = await query.FirstOrDefaultAsync(x => x.Name.Equals(name));

            return typeOfNutrition;
        }
    }
