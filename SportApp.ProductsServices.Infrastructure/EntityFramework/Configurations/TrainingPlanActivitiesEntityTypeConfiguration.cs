namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Activities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class TrainingPlanActivitiesEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<TrainingPlanActivities> builder)
        {
            builder.ToTable("TrainingPlanActivities");
            builder.HasKey("TrainingPlanId", "ActivityId"); //#A
            //-----------------------------
            //Relationships
            builder.HasOne(pt => pt.Activity) //#C
                .WithMany(p => p.TrainingPlanActivities) //#C
                .HasForeignKey("ActivityId"); //#C
            builder.HasOne(pt => pt.TrainingPlan) //#C
                .WithMany(p => p.TrainingPlanActivities) //#C
                .HasForeignKey("TrainingPlanId"); //#C
        }
    }
