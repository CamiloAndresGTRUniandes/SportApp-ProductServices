namespace SportApp.ProductsServices.Infrastructure.EntityFramework.ProductService.Repositories ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService.GeographicInfo;
using Domain.ProductService.Repositories;
using Microsoft.EntityFrameworkCore;

    public class StateRepository([NotNull] ProductServiceContext context) : IStateRepository
    {
        public async Task SaveAndPublishAsync(State state)
        {
            if (state.EntityState is EntityState.Added)
            {
                await context.States.AddAsync(state);
            }
            else
            {
                context.States.Attach(state);
            }
            await context.SaveChangesAsync();
        }

        public async Task<Country?> GetAllActiveByCountryAsync(Guid id)
        {
            var query = context.Countries.AsQueryable();
            query = query.Where(x => x.Enabled && x.Id == id);
            var country = await query.FirstOrDefaultAsync();
            if (country != null)
            {
                //await context.Entry(country).Reference(x => x.State).LoadAsync();
                await context.Entry(country).Collection(p => p.State).LoadAsync();
            }
            return country;
        }

        public async Task<State?> GetAllActiveCityByStateAsync(Guid id)
        {
            var query = context.States.AsQueryable();
            query = query.Where(x => x.Enabled && x.Id == id);
            var state = await query.FirstOrDefaultAsync();
            if (state != null)
            {
                //await context.Entry(country).Reference(x => x.State).LoadAsync();
                await context.Entry(state).Collection(p => p.City).LoadAsync();
            }
            return state;
        }
    }
