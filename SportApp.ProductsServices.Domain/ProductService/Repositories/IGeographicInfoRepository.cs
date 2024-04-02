﻿namespace SportApp.ProductsServices.Domain.ProductService.Repositories ;

    public interface IGeographicInfoRepository
    {
        Task SaveAndPublishAsync(GeographicInfo geographicInfo);
        Task<GeographicInfo?> GetByIdAsync(Guid id);
    }
