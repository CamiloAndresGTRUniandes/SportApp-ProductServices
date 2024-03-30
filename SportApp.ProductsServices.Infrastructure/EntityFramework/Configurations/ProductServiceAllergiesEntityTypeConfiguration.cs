namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Allergies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class ProductServiceAllergiesEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<ProductServiceAllergies> builder)
        {
            builder.ToTable("ProductServiceAllergies");
            builder.HasKey("ProductServiceId", "NutritionalAllergyId"); //#A
            //-----------------------------
            //Relationships
            builder.HasOne(pt => pt.NutritionalAllergy) //#C
                .WithMany(p => p.ProductServiceAllergies) //#C
                .HasForeignKey("NutritionalAllergyId"); //#C
            builder.HasOne(pt => pt.ProductService) //#C
                .WithMany(p => p.ProductServiceAllergies) //#C
                .HasForeignKey("ProductServiceId"); //#C
        }
    }
