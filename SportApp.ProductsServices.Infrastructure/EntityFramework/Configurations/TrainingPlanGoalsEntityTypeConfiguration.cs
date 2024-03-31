namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Goals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class TrainingPlanGoalsEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<TrainingPlanGoals> builder)
        {
            builder.ToTable("TrainingPlanGoals");
            builder.HasKey("TrainingPlanId", "GoalId"); //#A
            //-----------------------------
            //Relationships
            builder.HasOne(pt => pt.Goal) //#C
                .WithMany(p => p.TrainingPlanGoals) //#C
                .HasForeignKey("GoalId"); //#C
            builder.HasOne(pt => pt.TrainingPlan) //#C
                .WithMany(p => p.TrainingPlanGoals) //#C
                .HasForeignKey("TrainingPlanId"); //#C
        }
    }
