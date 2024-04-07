namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Training;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class UserTrainingPlanEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<UserTrainingPlan> builder)
        {
            builder.ToTable("UserTrainingPlans")
                .HasKey(k => k.Id);

            builder.Ignore(b => b.DomainMessages);
            builder.Ignore(b => b.EntityState);

            builder.Property(c => c.SubscribedUser)
                .HasColumnName(nameof(UserTrainingPlan.SubscribedUser))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired();

            builder.Property(c => c.CreatedBy)
                .HasColumnName(nameof(UserTrainingPlan.CreatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.UpdatedBy)
                .HasColumnName(nameof(UserTrainingPlan.UpdatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.Enabled)
                .HasColumnName(nameof(UserTrainingPlan.Enabled))
                .IsRequired()
                .HasDefaultValue(false);

            // Audit shadow properties
            builder.Property<DateTime>("CreatedAt");
            builder.Property<DateTime>("UpdatedAt");
        }
    }
