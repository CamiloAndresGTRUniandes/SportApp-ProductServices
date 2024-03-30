namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Activities;
using Domain.ProductService.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class ActivityEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activities")
                .HasKey(k => k.Id);

            builder.Ignore(b => b.DomainMessages);
            builder.Ignore(b => b.State);

            builder.Property(c => c.Name)
                .HasColumnName(nameof(Activity.Name))
                .HasConversion<string>(e => e, e => new Name(e))
                .HasMaxLength(50);

            builder.Property(c => c.CreatedBy)
                .HasColumnName(nameof(Activity.CreatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.UpdateBy)
                .HasColumnName(nameof(Activity.UpdateBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.Enabled)
                .HasColumnName(nameof(Activity.Enabled))
                .IsRequired()
                .HasDefaultValue(false);

            // Audit shadow properties
            builder.Property<DateTime>("CreatedAt");
            builder.Property<DateTime?>("UpdatedAt");
        }
    }
