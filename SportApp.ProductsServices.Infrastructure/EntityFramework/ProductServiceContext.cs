namespace SportApp.ProductsServices.Infrastructure.EntityFramework ;
using Configurations;
using Domain.Activities;
using Domain.Allergies;
using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Goals;
using Domain.ProductService;
using Domain.ProductService.ValueObjects;
using Domain.Training;
using Domain.Training.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

    public class ProductServiceContext(DbContextOptions<ProductServiceContext> options) : DbContext(options)
    {
        public DbSet<Domain.ProductService.ProductService> ProductServices { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<NutritionalAllergy> NutritionalAllergies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<GeographicInfo> GeographicInfo { get; set; }
        public DbSet<TypeOfNutrition> TypeOfNutrition { get; set; }
        public DbSet<ServiceType> ServiceType { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<TrainingPlan> TrainingPlans { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost; 
                Initial Catalog=SportAppProductsAndServices;user id=sa;password=St3v3n.930102*;Trust Server Certificate=true")
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
                .EnableSensitiveDataLogging();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainModel>())
            {
                switch (entry.State)
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
            modelBuilder.Entity<Activity>().Configure();
            modelBuilder.Entity<Goal>().Configure();
            modelBuilder.Entity<NutritionalAllergy>().Configure();
            modelBuilder.Entity<Category>().Configure();
            modelBuilder.Entity<Plan>().Configure();
            modelBuilder.Entity<ServiceType>().Configure();
            modelBuilder.Entity<TypeOfNutrition>().Configure();
            modelBuilder.Entity<Exercise>().Configure();
            modelBuilder.Entity<Training>().Configure();
            modelBuilder.Entity<TrainingPlan>().Configure();

            // Many-To-Many
            modelBuilder.Entity<ProductServiceActivities>().Configure();
            modelBuilder.Entity<ProductServiceGoals>().Configure();
            modelBuilder.Entity<ProductServiceAllergies>().Configure();
            modelBuilder.Entity<TrainingPlanGoals>().Configure();
            modelBuilder.Entity<TrainingPlanActivities>().Configure();
        }
    }
