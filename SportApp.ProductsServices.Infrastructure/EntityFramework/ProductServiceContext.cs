namespace SportApp.ProductsServices.Infrastructure.EntityFramework ;
using Configurations;
using Domain.Activities;
using Domain.Allergies;
using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Goals;
using Domain.Nutrition;
using Domain.ProductService;
using Domain.ProductService.GeographicInfo;
using Domain.ProductService.ValueObjects;
using Domain.Training;
using Domain.Training.ValueObjects;
using Microsoft.EntityFrameworkCore;

    public class ProductServiceContext(DbContextOptions<ProductServiceContext> options) : DbContext(options)
    {
        public DbSet<Domain.ProductService.ProductService> ProductServices { get; init; }
        public DbSet<Domain.Activities.Activity> Activities { get; init; }
        public DbSet<Domain.Goals.Goal> Goals { get; init; }
        public DbSet<Domain.Allergies.NutritionalAllergy> NutritionalAllergies { get; init; }
        public DbSet<Category> Categories { get; init; }
        public DbSet<Plan> Plans { get; init; }
        public DbSet<GeographicInfo> GeographicInfo { get; init; }
        public DbSet<TypeOfNutrition> TypeOfNutrition { get; init; }
        public DbSet<ServiceType> ServiceType { get; init; }
        public DbSet<Exercise> Exercises { get; init; }
        public DbSet<Training> Trainings { get; init; }
        public DbSet<TrainingPlan> TrainingPlans { get; init; }
        public DbSet<State> States { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<NutritionalPlan> NutritionalPlans { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Domain.Subscription.Subscription> Subscriptions { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=localhost; 
        //        Initial Catalog=SportAppProductsAndServices;user id=sa;password=St3v3n.930102*;Trust Server Certificate=true")
        //        .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
        //        .EnableSensitiveDataLogging();
        //}

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainModel>())
            {
                switch (entry.Entity.EntityState)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedAt = DateTime.Now;
                        break;

                    case EntityState.Modified:
                        entry.Entity.UpdatedAt = DateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.UseCollation("latin1_swedish_ci");
            modelBuilder.Ignore<Description>();
            modelBuilder.Ignore<Price>();
            modelBuilder.Ignore<Set>();
            modelBuilder.Ignore<Name>();
            modelBuilder.Ignore<Repeat>();
            modelBuilder.Ignore<Repeat>();
            modelBuilder.Ignore<Weight>();
            modelBuilder.Ignore<Age>();

            // ProductService
            modelBuilder.Entity<Domain.ProductService.ProductService>().Configure();
            modelBuilder.Entity<Domain.Activities.Activity>().Configure();
            modelBuilder.Entity<Domain.Goals.Goal>().Configure();
            modelBuilder.Entity<Domain.Allergies.NutritionalAllergy>().Configure();
            modelBuilder.Entity<Category>().Configure();
            modelBuilder.Entity<Plan>().Configure();
            modelBuilder.Entity<ServiceType>().Configure();
            modelBuilder.Entity<TypeOfNutrition>().Configure();
            modelBuilder.Entity<Exercise>().Configure();
            modelBuilder.Entity<Training>().Configure();
            modelBuilder.Entity<TrainingPlan>().Configure();
            modelBuilder.Entity<UserTrainingPlan>().Configure();
            modelBuilder.Entity<Country>().Configure();
            modelBuilder.Entity<State>().Configure();
            modelBuilder.Entity<City>().Configure();
            modelBuilder.Entity<Meal>().Configure();
            modelBuilder.Entity<Day>().Configure();
            modelBuilder.Entity<NutritionalPlan>().Configure();
            modelBuilder.Entity<Domain.Subscription.Subscription>().Configure();

            // Many-To-Many
            modelBuilder.Entity<ProductServiceActivities>().Configure();
            modelBuilder.Entity<ProductServiceGoals>().Configure();
            modelBuilder.Entity<ProductServiceNutritionalAllergies>().Configure();
            modelBuilder.Entity<TrainingPlanGoals>().Configure();
            modelBuilder.Entity<TrainingPlanActivities>().Configure();
            modelBuilder.Entity<TrainingPlanUserTrainingPlans>().Configure();
            modelBuilder.Entity<NutritionalPlanGoals>().Configure();
            modelBuilder.Entity<NutritionalPlanUserNutritionalPlans>().Configure();
        }
    }
