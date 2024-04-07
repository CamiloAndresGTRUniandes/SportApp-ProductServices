namespace SportApp.ProductsServices.Infrastructure.EntityFramework.ProductService.Repositories ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService.GeographicInfo;
using Domain.ProductService.Repositories;
using Microsoft.EntityFrameworkCore;

    public class CountryRepository([NotNull] ProductServiceContext context) : ICountryRepository
    {
        public async Task SaveAndPublishAsync(Country country)
        {
            if (country.EntityState is EntityState.Added)
            {
                await context.Countries.AddAsync(country);
            }
            else
            {
                context.Countries.Attach(country);
            }
            await context.SaveChangesAsync();
        }

        public async Task<ICollection<Country>> GetAllActiveAsync()
        {
            var query = context.Countries.AsQueryable();
            query = query.Where(x => x.Enabled);
            var countries = await query.ToListAsync();

            return countries;
        }
    }
