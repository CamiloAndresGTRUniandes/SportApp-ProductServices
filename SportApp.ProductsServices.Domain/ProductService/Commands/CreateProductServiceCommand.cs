﻿namespace SportApp.ProductsServices.Domain.ProductService.Commands ;

using Common.Commands;
using Common.Enums;
using Common.ValueObjects;
using ValueObjects;

    public class CreateProductServiceCommand : IDomainRequest<ProductService>
    {
        public Guid Id { get; set; }
        public Name Name { get; set; }
        public Description Description { get; set; }
        public Price Price { get; set; }
        public Uri Picture { get; set; }
        public Guid User { get; set; }
        public Guid CountryId { get; set; }
        public Guid CityId { get; set; }
        public Guid StateId { get; set; }
        public Guid? PlanId { get; set; }
        public Guid? TypeOfNutritionId { get; set; }
        public NutritionalPlanDto? NutritionalPlan { get; set; }
        public TrainingPlanDto? TrainingPlan { get; set; }
        public Guid ServiceTypeId { get; set; }
        public SportLevel SportLevel { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public ICollection<Guid>? Activities { get; set; } = [];
        public ICollection<Guid>? Goals { get; set; } = [];
        public ICollection<Guid>? Allergies { get; set; } = [];
    }

    public class NutritionalPlanDto
    {
        public Guid Id { get; set; }
        public ICollection<DayDto>? Days { get; set; }
    }

    public class DayDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<MealDto>? Meals { get; set; }
    }

    public class MealDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Calories { get; set; } = 0;
        public string DishType { get; set; }
        public Uri Picture { get; set; }
    }

    public class TrainingPlanDto
    {
        public Guid Id { get; set; }
        public int StartAge { get; set; } = 0;
        public int EndAge { get; set; } = 0;
        public ICollection<TrainingDto>? Trainings { get; set; }
    }

    public class TrainingDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ExerciseDto>? Exercises { get; set; }
    }

    public class ExerciseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Sets { get; set; } = 0;
        public int Repeats { get; set; } = 0;
        public long Weight { get; set; } = 0;
        public Uri Picture { get; set; }
    }
