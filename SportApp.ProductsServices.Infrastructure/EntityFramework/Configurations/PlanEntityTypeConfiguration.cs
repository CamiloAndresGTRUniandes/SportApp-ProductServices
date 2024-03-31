namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Common.ValueObjects;
using Domain.ProductService;
using Domain.ProductService.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class PlanEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<Plan> builder)
        {
            builder.ToTable("Plans")
                .HasKey(k => k.Id);

            builder.Ignore(b => b.DomainMessages);
            builder.Ignore(b => b.State);

            builder.Property(c => c.Name)
                .HasColumnName(nameof(Plan.Name))
                .HasConversion<string>(e => e, e => new Name(e))
                .HasMaxLength(50);

            builder.Property(c => c.Price)
                .HasColumnName(nameof(Plan.Price))
                .HasConversion(e => (long)e!, e => new Price(e))
                .HasMaxLength(50);

            builder.Property(c => c.Description)
                .HasColumnName(nameof(Plan.Description))
                .HasConversion<string>(e => e, e => new Description(e))
                .HasMaxLength(50);

            builder.Property(c => c.CreatedBy)
                .HasColumnName(nameof(Plan.CreatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.UpdatedBy)
                .HasColumnName(nameof(Plan.UpdatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.Enabled)
                .HasColumnName(nameof(Plan.Enabled))
                .IsRequired()
                .HasDefaultValue(false);

            // Audit shadow properties
            builder.Property<DateTime>("CreatedAt");
            builder.Property<DateTime>("UpdatedAt");

            //Add Default Data
            builder.HasData(
                Plan.Build(
                    Guid.Parse("672d4087-ac82-42b5-846e-64905d1a09b3"),
                    "Basic",
                    "Basic Plan",
                    0,
                    Guid.Parse("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6")),
                Plan.Build(
                    Guid.Parse("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                    "Intermediate",
                    "Intermediate Plan",
                    50,
                    Guid.Parse("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6")),
                Plan.Build(
                    Guid.Parse("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                    "Premium",
                    "Premium Plan",
                    150,
                    Guid.Parse("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"))
                );
        }
    }
