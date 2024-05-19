namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Common.ValueObjects;
using Domain.Recommendations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class RecommendationEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<Recommendation> builder)
        {
            builder.ToTable("Recommendations")
                .HasKey(k => k.Id);

            builder.Ignore(b => b.DomainMessages);
            builder.Ignore(b => b.EntityState);

            builder.Property(c => c.CreatedBy)
                .HasColumnName(nameof(Recommendation.CreatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.UpdatedBy)
                .HasColumnName(nameof(Recommendation.UpdatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.Enabled)
                .HasColumnName(nameof(Recommendation.Enabled))
                .IsRequired()
                .HasDefaultValue(false);

            // Audit shadow properties
            builder.Property<DateTime>("CreatedAt");
            builder.Property<DateTime>("UpdatedAt");
        }
}
