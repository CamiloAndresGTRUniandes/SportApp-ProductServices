﻿namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Common.ValueObjects;
using Domain.Goals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class GoalEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<Goal> builder)
        {
            builder.ToTable("Goals")
                .HasKey(k => k.Id);

            builder.Ignore(b => b.DomainMessages);
            builder.Ignore(b => b.EntityState);

            builder.Property(c => c.Name)
                .HasColumnName(nameof(Goal.Name))
                .HasConversion<string>(e => e, e => new Name(e))
                .HasMaxLength(50);

            builder.Property(c => c.CreatedBy)
                .HasColumnName(nameof(Goal.CreatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.UpdatedBy)
                .HasColumnName(nameof(Goal.UpdatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.Enabled)
                .HasColumnName(nameof(Goal.Enabled))
                .IsRequired()
                .HasDefaultValue(false);

            // Audit shadow properties
            builder.Property<DateTime>("CreatedAt");
            builder.Property<DateTime>("UpdatedAt");
        }
    }
