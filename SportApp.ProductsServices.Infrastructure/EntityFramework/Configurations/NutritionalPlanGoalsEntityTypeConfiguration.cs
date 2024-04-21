namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Goals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class NutritionalPlanGoalsEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<NutritionalPlanGoals> builder)
        {
            builder.ToTable("NutritionalPlanGoals");
            builder.HasKey("NutritionalPlanId", "GoalId"); //#A
            //-----------------------------
            //Relationships
            builder.HasOne(pt => pt.Goal) //#C
                .WithMany(p => p.NutritionalPlanGoals) //#C
                .HasForeignKey("GoalId"); //#C
            builder.HasOne(pt => pt.NutritionalPlan) //#C
                .WithMany(p => p.NutritionalPlanGoals) //#C
                .HasForeignKey("NutritionalPlanId"); //#C
        }
    }
