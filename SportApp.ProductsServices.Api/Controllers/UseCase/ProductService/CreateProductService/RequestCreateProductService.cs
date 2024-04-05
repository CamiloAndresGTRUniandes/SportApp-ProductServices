﻿namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.CreateProductService ;
using System.ComponentModel.DataAnnotations;

    public class RequestCreateProductService
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public long? Price { get; set; }
        public Uri Picture { get; set; }

        [Required]
        public Guid User { get; set; }

        [Required]
        public Guid GeographicInfoId { get; set; }

        public Guid? PlanId { get; set; }
        public Guid? TypeOfNutritionId { get; set; }
        public string SportLevel { get; set; }

        [Required]
        public Guid ServiceTypeId { get; set; }

        public ICollection<Guid>? Activities { get; set; } = new List<Guid>();
        public ICollection<Guid>? Goals { get; set; } = new List<Guid>();
        public ICollection<Guid>? Allergies { get; set; } = new List<Guid>();
    }
