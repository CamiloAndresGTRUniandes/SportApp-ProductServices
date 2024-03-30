﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportApp.ProductsServices.Infrastructure.EntityFramework;

#nullable disable

namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Migrations
{
    [DbContext(typeof(ProductServiceContext))]
    [Migration("20240330062419_InitialCreation")]
    partial class InitialCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("latin1_swedish_ci")
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Activities.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatedBy");

                    b.Property<bool>("Enabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("Enabled");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UpdateBy");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Activities", (string)null);
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Activities.ProductServiceActivities", b =>
                {
                    b.Property<Guid>("ProductServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ActivityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductServiceId", "ActivityId");

                    b.HasIndex("ActivityId");

                    b.ToTable("ProductServiceActivities", (string)null);
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Allergies.NutritionalAllergy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatedBy");

                    b.Property<bool>("Enabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("Enabled");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UpdateBy");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("NutritionalAllergies", (string)null);
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Allergies.ProductServiceAllergies", b =>
                {
                    b.Property<Guid>("ProductServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("NutritionalAllergyId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductServiceId", "NutritionalAllergyId");

                    b.HasIndex("NutritionalAllergyId");

                    b.ToTable("ProductServiceAllergies", (string)null);
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Goals.Goal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatedBy");

                    b.Property<bool>("Enabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("Enabled");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UpdateBy");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Goals", (string)null);
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Goals.ProductServiceGoals", b =>
                {
                    b.Property<Guid>("ProductServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GoalId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductServiceId", "GoalId");

                    b.HasIndex("GoalId");

                    b.ToTable("ProductServiceGoals", (string)null);
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.ProductService.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.ProductService.GeographicInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<Guid>("StateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("GeographicInfo");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.ProductService.Plan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.ProductService.ProductService", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatedBy");

                    b.Property<string>("Description")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("")
                        .HasColumnName("Description");

                    b.Property<bool>("Enabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("Enabled");

                    b.Property<Guid>("GeographicInfoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Price")
                        .HasMaxLength(50)
                        .HasColumnType("bigint")
                        .HasColumnName("Price");

                    b.Property<Guid>("ServiceTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TypeOfNutritionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UpdateBy");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GeographicInfoId");

                    b.HasIndex("PlanId");

                    b.HasIndex("ServiceTypeId");

                    b.HasIndex("TypeOfNutritionId");

                    b.ToTable("ProductServices", (string)null);
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.ProductService.ServiceType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ServiceType");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.ProductService.TypeOfNutrition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("TypeOfNutrition");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Activities.ProductServiceActivities", b =>
                {
                    b.HasOne("SportApp.ProductsServices.Domain.Activities.Activity", "Activity")
                        .WithMany("ProductServiceActivities")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportApp.ProductsServices.Domain.ProductService.ProductService", "ProductService")
                        .WithMany("ProductServiceActivities")
                        .HasForeignKey("ProductServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("ProductService");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Allergies.ProductServiceAllergies", b =>
                {
                    b.HasOne("SportApp.ProductsServices.Domain.Allergies.NutritionalAllergy", "NutritionalAllergy")
                        .WithMany("ProductServiceAllergies")
                        .HasForeignKey("NutritionalAllergyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportApp.ProductsServices.Domain.ProductService.ProductService", "ProductService")
                        .WithMany("ProductServiceAllergies")
                        .HasForeignKey("ProductServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NutritionalAllergy");

                    b.Navigation("ProductService");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Goals.ProductServiceGoals", b =>
                {
                    b.HasOne("SportApp.ProductsServices.Domain.Goals.Goal", "Goal")
                        .WithMany("ProductServiceGoals")
                        .HasForeignKey("GoalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportApp.ProductsServices.Domain.ProductService.ProductService", "ProductService")
                        .WithMany("ProductServiceGoals")
                        .HasForeignKey("ProductServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Goal");

                    b.Navigation("ProductService");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.ProductService.ProductService", b =>
                {
                    b.HasOne("SportApp.ProductsServices.Domain.ProductService.GeographicInfo", "GeographicInfo")
                        .WithMany()
                        .HasForeignKey("GeographicInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportApp.ProductsServices.Domain.ProductService.Plan", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportApp.ProductsServices.Domain.ProductService.ServiceType", "ServiceType")
                        .WithMany()
                        .HasForeignKey("ServiceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportApp.ProductsServices.Domain.ProductService.TypeOfNutrition", "TypeOfNutrition")
                        .WithMany()
                        .HasForeignKey("TypeOfNutritionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GeographicInfo");

                    b.Navigation("Plan");

                    b.Navigation("ServiceType");

                    b.Navigation("TypeOfNutrition");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.ProductService.ServiceType", b =>
                {
                    b.HasOne("SportApp.ProductsServices.Domain.ProductService.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Activities.Activity", b =>
                {
                    b.Navigation("ProductServiceActivities");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Allergies.NutritionalAllergy", b =>
                {
                    b.Navigation("ProductServiceAllergies");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Goals.Goal", b =>
                {
                    b.Navigation("ProductServiceGoals");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.ProductService.ProductService", b =>
                {
                    b.Navigation("ProductServiceActivities");

                    b.Navigation("ProductServiceAllergies");

                    b.Navigation("ProductServiceGoals");
                });
#pragma warning restore 612, 618
        }
    }
}
