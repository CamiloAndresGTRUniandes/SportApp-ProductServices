namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Common;
using Domain.Common.Enums;
using Domain.Common.ValueObjects;
using Domain.ProductService;
using Domain.ProductService.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class ProductServiceEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<ProductService> builder)
        {
            builder.ToTable("ProductServices")
                .HasKey(k => k.Id);

            builder.Ignore(b => b.DomainMessages);
            builder.Ignore(b => b.State);

            builder.Property(c => c.Name)
                .HasColumnName(nameof(ProductService.Name))
                .HasConversion<string>(e => e, e => new Name(e))
                .HasMaxLength(50);

            builder.Property(c => c.Description)
                .HasColumnName(nameof(ProductService.Description))
                .HasConversion<string>(e => e, e => new Description(e))
                .HasDefaultValue((Description)string.Empty)
                .HasMaxLength(50);

            builder.Property(c => c.Price)
                .HasColumnName(nameof(ProductService.Price))
                .HasConversion(e => (long)e!, e => new Price(e))
                .HasMaxLength(50);

            builder.Property(p => p.SportLevel)
                .HasColumnName(nameof(ProductService.SportLevel))
                .HasConversion(p => p.Name, p => (string.IsNullOrWhiteSpace(p) ? null : Enumeration.FromDisplayName<SportLevel>(p))!)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(c => c.CreatedBy)
                .HasColumnName(nameof(ProductService.CreatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.UpdatedBy)
                .HasColumnName(nameof(ProductService.UpdatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.Enabled)
                .HasColumnName(nameof(ProductService.Enabled))
                .IsRequired()
                .HasDefaultValue(false);

            // Audit shadow properties
            builder.Property<DateTime>("CreatedAt");
            builder.Property<DateTime>("UpdatedAt");
        }
    }
