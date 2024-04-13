namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Training;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class TrainingPlanUserTrainingPlansEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<TrainingPlanUserTrainingPlans> builder)
        {
            builder.ToTable("TrainingPlanUserTrainingPlans");
            builder.HasKey("TrainingPlanId", "UserTrainingPlanId"); //#A
            //-----------------------------
            //Relationships
            builder.HasOne(pt => pt.UserTrainingPlan) //#C
                .WithMany(p => p.TrainingPlanUserTrainingPlans) //#C
                .HasForeignKey("UserTrainingPlanId"); //#C
            builder.HasOne(pt => pt.TrainingPlan) //#C
                .WithMany(p => p.TrainingPlanUserTrainingPlans) //#C
                .HasForeignKey("TrainingPlanId"); //#C
        }
    }
