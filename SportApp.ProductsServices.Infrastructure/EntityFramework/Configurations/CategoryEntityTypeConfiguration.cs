namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Configurations ;
using Domain.Common.ValueObjects;
using Domain.ProductService;
using Domain.ProductService.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class CategoryEntityTypeConfiguration
    {
        internal static void Configure(this EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories")
                .HasKey(k => k.Id);

            //builder.HasMany(e => e.ServiceType).WithOne().IsRequired().OnDelete(DeleteBehavior.NoAction);
            //builder.Metadata.FindNavigation(nameof(Category.ServiceType));

            builder.Ignore(b => b.DomainMessages);
            builder.Ignore(b => b.EntityState);

            builder.Property(c => c.Name)
                .HasColumnName(nameof(Category.Name))
                .HasConversion<string>(e => e, e => new Name(e))
                .HasMaxLength(50);

            builder.Property(c => c.Description)
                .HasColumnName(nameof(Category.Description))
                .HasConversion<string>(e => e, e => new Description(e))
                .HasMaxLength(250);

            builder.Property(c => c.CreatedBy)
                .HasColumnName(nameof(Category.CreatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.UpdatedBy)
                .HasColumnName(nameof(Category.UpdatedBy))
                .HasConversion(p => p, p => p)
                .HasMaxLength(36)
                .IsRequired(false);

            builder.Property(c => c.Enabled)
                .HasColumnName(nameof(Category.Enabled))
                .IsRequired()
                .HasDefaultValue(false);

            // Audit shadow properties
            builder.Property<DateTime>("CreatedAt");
            builder.Property<DateTime>("UpdatedAt");

            //Add Default Data
            builder.HasData(
                Category.Build(
                    Guid.Parse("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                    "Default Category",
                    "This is the default category",
                    Guid.Parse("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6")),
                Category.Build(
                    Guid.Parse("be8e2306-8bc9-49cc-8d43-a76820370994"),
                    "Eventos",
                    "Categoría para eventos de todo tipo",
                    Guid.Parse("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6")),
                Category.Build(
                    Guid.Parse("a649e6a9-f667-4e73-b8b6-3816c7e554eb"),
                    "Productos",
                    "Categoría para productos de todo tipo",
                    Guid.Parse("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6")),
                Category.Build(
                    Guid.Parse("60d40a85-78ca-4b75-b75f-76cee4896ead"),
                    "Servicios",
                    "Categoría para servicios de todo tipo",
                    Guid.Parse("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"))
                );
        }
    }
