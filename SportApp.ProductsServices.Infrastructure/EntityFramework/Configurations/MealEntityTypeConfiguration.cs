namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Nutrition;
using Domain.Nutrition.ValueObjects;
using Domain.ProductService.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class MealEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<Meal> builder)
        {
            builder.ToTable("Meals")
                .HasKey(k => k.Id);

            builder.Ignore(b => b.DomainMessages);
            builder.Ignore(b => b.EntityState);

            builder.Property(c => c.Name)
                .HasColumnName(nameof(Meal.Name))
                .HasConversion<string>(e => e, e => new Name(e))
                .HasMaxLength(50);

            builder.Property(c => c.Description)
                .HasColumnName(nameof(Meal.Description))
                .HasConversion<string>(e => e, e => new Description(e))
                .HasMaxLength(50);

            builder.Property(c => c.Calories)
                .HasColumnName(nameof(Meal.Calories))
                .HasConversion<int>(e => e, e => new Calories(e))
                .IsRequired();
            builder.Property(p => p.DishType)
                .HasColumnName(nameof(Meal.DishType))
                .HasConversion(p => p.Name, p => (string.IsNullOrWhiteSpace(p) ? null : Enumeration.FromDisplayName<DishType>(p))!)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(c => c.Picture)
                .HasColumnName(nameof(Meal.Picture))
                .IsRequired(false);

            builder.Property(c => c.CreatedBy)
                .HasColumnName(nameof(Meal.CreatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.UpdatedBy)
                .HasColumnName(nameof(Meal.UpdatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.Enabled)
                .HasColumnName(nameof(Meal.Enabled))
                .IsRequired()
                .HasDefaultValue(false);

            // Audit shadow properties
            builder.Property<DateTime>("CreatedAt");
            builder.Property<DateTime>("UpdatedAt");
        }
    }
