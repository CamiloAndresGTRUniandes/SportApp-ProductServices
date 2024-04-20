namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Nutrition;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class UserNutritionalPlanEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<UserNutritionalPlan> builder)
        {
            builder.ToTable("UserNutritionalPlans")
                .HasKey(k => k.Id);

            builder.Ignore(b => b.DomainMessages);
            builder.Ignore(b => b.EntityState);

            builder.Property(c => c.SubscribedUser)
                .HasColumnName(nameof(UserNutritionalPlan.SubscribedUser))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired();

            builder.Property(c => c.CreatedBy)
                .HasColumnName(nameof(UserNutritionalPlan.CreatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.UpdatedBy)
                .HasColumnName(nameof(UserNutritionalPlan.UpdatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.Enabled)
                .HasColumnName(nameof(UserNutritionalPlan.Enabled))
                .IsRequired()
                .HasDefaultValue(false);

            // Audit shadow properties
            builder.Property<DateTime>("CreatedAt");
            builder.Property<DateTime>("UpdatedAt");
        }
    }
