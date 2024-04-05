﻿namespace SportApp.ProductsServices.Infrastructure.EntityFramework.ProductService.Repositories ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService;
using Domain.ProductService.Commands;
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

        public async Task<ICollection<ProductService>> GetAllWithParametersAsync(GetProductServiceCommand parameters)
        {
            var productServices = new List<ProductService>();
            var query = context.ProductServices.AsQueryable();
            if (parameters.Id.HasValue)
            {
                query.Where(x => x.Id == parameters.Id.Value);
                productServices = await query.ToListAsync();
                await IncludeOperations(productServices);
                return productServices;
            }
            if (parameters.ServiceTypes.Count != 0)
            {
                query.Where(x => parameters.ServiceTypes.Contains(x.ServiceType.Category.Id));
            }
            if (parameters.Plans.Count != 0)
            {
                query.Where(x => parameters.Plans.Contains(x.Plan.Id));
            }
            if (parameters.Activities.Count != 0)
            {
                foreach (var activityId in parameters.Activities)
                {
                    query.Where(x => x.ProductServiceActivities.Select(a => a.Activity.Id).Contains(activityId));
                }
            }
            if (parameters.Goals.Count != 0)
            {
                foreach (var goalId in parameters.Goals)
                {
                    query.Where(x => x.ProductServiceGoals.Select(a => a.Goal.Id).Contains(goalId));
                }
            }
            if (parameters.Allergies.Count != 0)
            {
                foreach (var allergyId in parameters.Allergies)
                {
                    query.Where(x => x.ProductServiceAllergies.Select(a => a.NutritionalAllergy.Id).Contains(allergyId));
                }
            }
            if (parameters.GeographicInfoIds.Count != 0)
            {
                query.Where(x => parameters.GeographicInfoIds.Contains(x.GeographicInfo!.Id));
            }

            if (parameters is { StartDateTime: not null, EndDateTime: not null })
            {
                query.Where(c => c.StartDateTime.HasValue && c.EndDateTime.HasValue)
                    .Where(c =>
                        c.StartDateTime!.Value >= parameters.StartDateTime!.Value && c.StartDateTime!.Value <= parameters.EndDateTime!.Value);
            }

            productServices = await query.ToListAsync();
            await IncludeOperations(productServices);
            return productServices;
        }

        private async Task IncludeOperations(ICollection<ProductService> productServices)
        {
            foreach (var productService in productServices)
            {
                await context.Entry(productService).Reference(e => e.Plan).LoadAsync();
                await context.Entry(productService).Reference(e => e.TypeOfNutrition).LoadAsync();
                await context.Entry(productService).Reference(e => e.GeographicInfo).LoadAsync();
                await context.Entry(productService).Reference(e => e.ServiceType).Query().Include(x => x.Category).LoadAsync();

                // Many-To-Many aggregations
                await context.Entry(productService).Collection(p => p.ProductServiceAllergies).Query().Include(p => p.NutritionalAllergy).LoadAsync();
                await context.Entry(productService).Collection(p => p.ProductServiceActivities).Query().Include(p => p.Activity).LoadAsync();
                await context.Entry(productService).Collection(p => p.ProductServiceGoals).Query().Include(p => p.Goal).LoadAsync();
            }
        }
    }
