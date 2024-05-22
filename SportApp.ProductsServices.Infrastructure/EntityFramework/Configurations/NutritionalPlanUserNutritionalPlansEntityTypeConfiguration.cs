namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Nutrition;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class NutritionalPlanUserNutritionalPlansEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<NutritionalPlanUserNutritionalPlans> builder)
        {
            builder.ToTable("NutritionalPlanUserNutritionalPlans");
            builder.HasKey("NutritionalPlanId", "UserNutritionalPlanId"); //#A
            //-----------------------------
            //Relationships
            builder.HasOne(pt => pt.UserNutritionalPlan) //#C
                .WithMany(p => p.NutritionalPlanUserNutritionalPlans) //#C
                .HasForeignKey("UserNutritionalPlanId"); //#C
            builder.HasOne(pt => pt.NutritionalPlan) //#C
                .WithMany(p => p.NutritionalPlanUserNutritionalPlans) //#C
                .HasForeignKey("NutritionalPlanId"); //#C
        }
    }
