﻿namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Training;
using Domain.Training.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class TrainingPlanEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<TrainingPlan> builder)
        {
            builder.ToTable("TrainingPlans")
                .HasKey(k => k.Id);

            builder.Ignore(b => b.DomainMessages);
            builder.Ignore(b => b.EntityState);

            builder.Property(c => c.StartAge)
                .HasColumnName(nameof(TrainingPlan.StartAge))
                .HasConversion<int>(e => e, e => new Age(e))
                .IsRequired();

            builder.Property(c => c.EndAge)
                .HasColumnName(nameof(TrainingPlan.EndAge))
                .HasConversion<int>(e => e, e => new Age(e))
                .IsRequired();

            builder.Property(c => c.CreatedBy)
                .HasColumnName(nameof(TrainingPlan.CreatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.UpdatedBy)
                .HasColumnName(nameof(TrainingPlan.UpdatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.Enabled)
                .HasColumnName(nameof(TrainingPlan.Enabled))
                .IsRequired()
                .HasDefaultValue(false);

            // Audit shadow properties
            builder.Property<DateTime>("CreatedAt");
            builder.Property<DateTime>("UpdatedAt");
        }
    }
