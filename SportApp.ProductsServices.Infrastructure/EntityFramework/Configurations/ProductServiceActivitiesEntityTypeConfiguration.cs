namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Activities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class ProductServiceActivitiesEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<ProductServiceActivities> builder)
        {
            builder.ToTable("ProductServiceActivities");
            builder.HasKey("ProductServiceId", "ActivityId"); //#A
            //-----------------------------
            //Relationships
            builder.HasOne(pt => pt.Activity) //#C
                .WithMany(p => p.ProductServiceActivities) //#C
                .HasForeignKey("ActivityId"); //#C
            builder.HasOne(pt => pt.ProductService) //#C
                .WithMany(p => p.ProductServiceActivities) //#C
                .HasForeignKey("ProductServiceId"); //#C
        }
    }
