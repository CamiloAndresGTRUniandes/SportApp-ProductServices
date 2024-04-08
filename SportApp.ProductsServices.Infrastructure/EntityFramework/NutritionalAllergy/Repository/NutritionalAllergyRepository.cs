namespace SportApp.ProductsServices.Infrastructure.EntityFramework.NutritionalAllergy.Repository ;
using System.Diagnostics.CodeAnalysis;
using Domain.Allergies;
using Domain.Allergies.Repositories;
using Domain.Common.ValueObjects;
using Microsoft.EntityFrameworkCore;

    public class NutritionalAllergyRepository([NotNull] ProductServiceContext context) : INutritionalAllergyRepository
    {
        public async Task SaveAndPublishAsync(NutritionalAllergy allergy)
        {
            if (allergy.EntityState is EntityState.Added)
            {
                await context.NutritionalAllergies.AddAsync(allergy);
            }
            else
            {
                context.NutritionalAllergies.Attach(allergy);
            }
            await context.SaveChangesAsync();
        }

        public async Task<NutritionalAllergy?> GetByIdAsync(Guid id)
        {
            var query = context.NutritionalAllergies.AsQueryable();
            var allergy = await query.FirstOrDefaultAsync(x => x.Enabled && x.Id == id);

            return allergy;
        }

        public async Task<ICollection<NutritionalAllergy>> GetAllActiveAsync()
        {
            var query = context.NutritionalAllergies.AsQueryable();
            var nutritionalAllergies = await query.Where(a => a.Enabled).ToListAsync();
            return nutritionalAllergies;
        }

        public async Task<NutritionalAllergy?> GetByNameAsync(Name name)
        {
            var query = context.NutritionalAllergies.AsQueryable();
            var allergy = await query.FirstOrDefaultAsync(x => x.Name.Equals(name));

            return allergy;
        }
    }
