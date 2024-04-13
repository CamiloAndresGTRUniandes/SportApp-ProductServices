namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Goals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class ProductServiceGoalsEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<ProductServiceGoals> builder)
        {
            builder.ToTable("ProductServiceGoals");
            builder.HasKey("ProductServiceId", "GoalId"); //#A
            //-----------------------------
            //Relationships
            builder.HasOne(pt => pt.Goal) //#C
                .WithMany(p => p.ProductServiceGoals) //#C
                .HasForeignKey("GoalId"); //#C
            builder.HasOne(pt => pt.ProductService) //#C
                .WithMany(p => p.ProductServiceGoals) //#C
                .HasForeignKey("ProductServiceId"); //#C
        }
    }
