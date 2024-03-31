namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Common.ValueObjects;
using Domain.ProductService.ValueObjects;
using Domain.Training;
using Domain.Training.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class ExerciseEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<Exercise> builder)
        {
            builder.ToTable("Exercises")
                .HasKey(k => k.Id);

            builder.Ignore(b => b.DomainMessages);
            builder.Ignore(b => b.State);

            builder.Property(c => c.Name)
                .HasColumnName(nameof(Exercise.Name))
                .HasConversion<string>(e => e, e => new Name(e))
                .HasMaxLength(50);

            builder.Property(c => c.Description)
                .HasColumnName(nameof(Exercise.Description))
                .HasConversion<string>(e => e, e => new Description(e))
                .HasMaxLength(50);

            builder.Property(c => c.Sets)
                .HasColumnName(nameof(Exercise.Sets))
                .HasConversion<int>(e => e, e => new Set(e))
                .IsRequired();

            builder.Property(c => c.Repeats)
                .HasColumnName(nameof(Exercise.Repeats))
                .HasConversion<int>(e => e, e => new Repeat(e))
                .IsRequired();

            builder.Property(c => c.Weight)
                .HasColumnName(nameof(Exercise.Weight))
                .HasConversion<long?>(e => e, e => new Weight(e))
                .IsRequired(false);

            builder.Property(c => c.Picture)
                .HasColumnName(nameof(Exercise.Picture))
                .IsRequired(false);

            builder.Property(c => c.CreatedBy)
                .HasColumnName(nameof(Exercise.CreatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.UpdatedBy)
                .HasColumnName(nameof(Exercise.UpdatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.Enabled)
                .HasColumnName(nameof(Exercise.Enabled))
                .IsRequired()
                .HasDefaultValue(false);

            // Audit shadow properties
            builder.Property<DateTime>("CreatedAt");
            builder.Property<DateTime>("UpdatedAt");
        }
    }
