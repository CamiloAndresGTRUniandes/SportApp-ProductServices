namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Allergies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class ProductServiceAllergiesEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<ProductServiceNutritionalAllergies> builder)
        {
            builder.ToTable("ProductServiceNutritionalAllergies");
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
