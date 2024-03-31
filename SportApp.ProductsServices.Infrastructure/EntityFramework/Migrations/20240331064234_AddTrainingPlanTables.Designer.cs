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
    [Migration("20240331064234_AddTrainingPlanTables")]
    partial class AddTrainingPlanTables
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

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UpdatedBy");

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

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Activities.TrainingPlanActivities", b =>
                {
                    b.Property<Guid>("TrainingPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ActivityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TrainingPlanId", "ActivityId");

                    b.HasIndex("ActivityId");

                    b.ToTable("TrainingPlanActivities", (string)null);
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

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UpdatedBy");

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

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UpdatedBy");

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

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Goals.TrainingPlanGoals", b =>
                {
                    b.Property<Guid>("TrainingPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GoalId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TrainingPlanId", "GoalId");

                    b.HasIndex("GoalId");

                    b.ToTable("TrainingPlanGoals", (string)null);
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.ProductService.Category", b =>
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Description");

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

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);
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

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
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
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatedBy");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Description");

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

                    b.Property<long>("Price")
                        .HasMaxLength(50)
                        .HasColumnType("bigint")
                        .HasColumnName("Price");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Plans", (string)null);
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

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UpdatedBy");

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
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatedBy");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Description");

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

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ServiceType", (string)null);
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.ProductService.TypeOfNutrition", b =>
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

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("TypeOfNutrition", (string)null);
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Training.Exercise", b =>
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Description");

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

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Picture");

                    b.Property<int>("Repeats")
                        .HasColumnType("int")
                        .HasColumnName("Repeats");

                    b.Property<int>("Sets")
                        .HasColumnType("int")
                        .HasColumnName("Sets");

                    b.Property<Guid>("TrainingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UpdatedBy");

                    b.Property<long?>("Weight")
                        .HasColumnType("bigint")
                        .HasColumnName("Weight");

                    b.HasKey("Id");

                    b.HasIndex("TrainingId");

                    b.ToTable("Exercises", (string)null);
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Training.Training", b =>
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Description");

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

                    b.Property<Guid?>("TrainingPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("TrainingPlanId");

                    b.ToTable("Trainings", (string)null);
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Training.TrainingPlan", b =>
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Description");

                    b.Property<bool>("Enabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("Enabled");

                    b.Property<int>("EndAge")
                        .HasColumnType("int")
                        .HasColumnName("EndAge");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<string>("SportLevel")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("SportLevel");

                    b.Property<int>("StartAge")
                        .HasColumnType("int")
                        .HasColumnName("StartAge");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("TrainingPlans", (string)null);
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

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Activities.TrainingPlanActivities", b =>
                {
                    b.HasOne("SportApp.ProductsServices.Domain.Activities.Activity", "Activity")
                        .WithMany("TrainingPlanActivities")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportApp.ProductsServices.Domain.Training.TrainingPlan", "TrainingPlan")
                        .WithMany("TrainingPlanActivities")
                        .HasForeignKey("TrainingPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("TrainingPlan");
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

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Goals.TrainingPlanGoals", b =>
                {
                    b.HasOne("SportApp.ProductsServices.Domain.Goals.Goal", "Goal")
                        .WithMany("TrainingPlanGoals")
                        .HasForeignKey("GoalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportApp.ProductsServices.Domain.Training.TrainingPlan", "TrainingPlan")
                        .WithMany("TrainingPlanGoals")
                        .HasForeignKey("TrainingPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Goal");

                    b.Navigation("TrainingPlan");
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

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Training.Exercise", b =>
                {
                    b.HasOne("SportApp.ProductsServices.Domain.Training.Training", null)
                        .WithMany("Exercise")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Training.Training", b =>
                {
                    b.HasOne("SportApp.ProductsServices.Domain.Training.TrainingPlan", null)
                        .WithMany("Training")
                        .HasForeignKey("TrainingPlanId");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Activities.Activity", b =>
                {
                    b.Navigation("ProductServiceActivities");

                    b.Navigation("TrainingPlanActivities");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Allergies.NutritionalAllergy", b =>
                {
                    b.Navigation("ProductServiceAllergies");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Goals.Goal", b =>
                {
                    b.Navigation("ProductServiceGoals");

                    b.Navigation("TrainingPlanGoals");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.ProductService.ProductService", b =>
                {
                    b.Navigation("ProductServiceActivities");

                    b.Navigation("ProductServiceAllergies");

                    b.Navigation("ProductServiceGoals");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Training.Training", b =>
                {
                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("SportApp.ProductsServices.Domain.Training.TrainingPlan", b =>
                {
                    b.Navigation("Training");

                    b.Navigation("TrainingPlanActivities");

                    b.Navigation("TrainingPlanGoals");
                });
#pragma warning restore 612, 618
        }
    }
}
