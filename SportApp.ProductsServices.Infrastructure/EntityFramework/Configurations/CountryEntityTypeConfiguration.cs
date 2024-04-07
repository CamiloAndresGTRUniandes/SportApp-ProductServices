namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Common.ValueObjects;
using Domain.ProductService.GeographicInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class CountryEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Countries")
                .HasKey(k => k.Id);

            builder.HasMany(e => e.States).WithOne().IsRequired().OnDelete(DeleteBehavior.Cascade);
            builder.Metadata.FindNavigation(nameof(Country.States));
            // .SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.Ignore(b => b.DomainMessages);
            builder.Ignore(b => b.State);

            builder.Property(c => c.Name)
                .HasColumnName(nameof(Country.Name))
                .HasConversion<string>(e => e, e => new Name(e))
                .HasMaxLength(50);

            builder.Property(c => c.CreatedBy)
                .HasColumnName(nameof(Country.CreatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.UpdatedBy)
                .HasColumnName(nameof(Country.UpdatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.Enabled)
                .HasColumnName(nameof(Country.Enabled))
                .IsRequired()
                .HasDefaultValue(false);

            // Audit shadow properties
            builder.Property<DateTime>("CreatedAt");
            builder.Property<DateTime>("UpdatedAt");
        }
    }
