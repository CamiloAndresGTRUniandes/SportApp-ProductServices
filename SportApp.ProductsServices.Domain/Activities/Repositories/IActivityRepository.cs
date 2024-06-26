﻿namespace SportApp.ProductsServices.Domain.Activities.Repositories ;
using Common.ValueObjects;

    public interface IActivityRepository
    {
        Task SaveAndPublishAsync(Activity activity);
        Task<Activity?> GetByIdAsync(Guid id);
        Task<ICollection<Activity>> GetAllActiveAsync();
        Task<Activity?> GetByNameAsync(Name name);
    }
