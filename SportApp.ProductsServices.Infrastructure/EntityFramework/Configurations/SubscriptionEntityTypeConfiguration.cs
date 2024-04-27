namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Subscription;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class SubscriptionEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<Subscription> builder)
        {
            builder.ToTable("Subscriptions")
                .HasKey(k => k.Id);

            builder.Ignore(b => b.DomainMessages);
            builder.Ignore(b => b.EntityState);

            builder.Property(c => c.CreatedBy)
                .HasColumnName(nameof(Subscription.CreatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.User)
                .HasColumnName(nameof(Subscription.User))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36);

            builder.Property(c => c.StartDate)
                .HasColumnName(nameof(Subscription.StartDate))
                .IsRequired();

            builder.Property(c => c.EndDate)
                .HasColumnName(nameof(Subscription.EndDate))
                .IsRequired();

            builder.Property(c => c.UpdatedBy)
                .HasColumnName(nameof(Subscription.UpdatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.Enabled)
                .HasColumnName(nameof(Subscription.Enabled))
                .IsRequired()
                .HasDefaultValue(false);

            // Audit shadow properties
            builder.Property<DateTime>("CreatedAt");
            builder.Property<DateTime>("UpdatedAt");
        }
    }
