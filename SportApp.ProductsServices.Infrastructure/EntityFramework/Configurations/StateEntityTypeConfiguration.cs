namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Common.ValueObjects;
using Domain.ProductService.GeographicInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class StateEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<State> builder)
        {
            builder.ToTable("States")
                .HasKey(k => k.Id);

            builder.HasMany(e => e.City).WithOne().IsRequired().OnDelete(DeleteBehavior.Cascade);
            builder.Metadata.FindNavigation(nameof(State.City));
            // .SetPropertyAccessMode(PropertyAccessMode.Field);
            builder.HasOne(p => p.Country).WithMany().HasForeignKey("CountryId").IsRequired().OnDelete(DeleteBehavior.NoAction);


            builder.Ignore(b => b.DomainMessages);
            builder.Ignore(b => b.State);

            builder.Property(c => c.Name)
                .HasColumnName(nameof(State.Name))
                .HasConversion<string>(e => e, e => new Name(e))
                .HasMaxLength(50);

            builder.Property(c => c.CreatedBy)
                .HasColumnName(nameof(State.CreatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.UpdatedBy)
                .HasColumnName(nameof(State.UpdatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.Enabled)
                .HasColumnName(nameof(State.Enabled))
                .IsRequired()
                .HasDefaultValue(false);

            // Audit shadow properties
            builder.Property<DateTime>("CreatedAt");
            builder.Property<DateTime>("UpdatedAt");
        }
    }
