using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataBaseCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeographicInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeographicInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NutritionalAllergies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionalAllergies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<long>(type: "bigint", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartAge = table.Column<int>(type: "int", nullable: false),
                    EndAge = table.Column<int>(type: "int", nullable: false),
                    SportLevel = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfNutrition",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfNutrition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTrainingPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscribedUser = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTrainingPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceType_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPlanActivities",
                columns: table => new
                {
                    TrainingPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPlanActivities", x => new { x.TrainingPlanId, x.ActivityId });
                    table.ForeignKey(
                        name: "FK_TrainingPlanActivities_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingPlanActivities_TrainingPlans_TrainingPlanId",
                        column: x => x.TrainingPlanId,
                        principalTable: "TrainingPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPlanGoals",
                columns: table => new
                {
                    TrainingPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPlanGoals", x => new { x.TrainingPlanId, x.GoalId });
                    table.ForeignKey(
                        name: "FK_TrainingPlanGoals_Goals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingPlanGoals_TrainingPlans_TrainingPlanId",
                        column: x => x.TrainingPlanId,
                        principalTable: "TrainingPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrainingPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainings_TrainingPlans_TrainingPlanId",
                        column: x => x.TrainingPlanId,
                        principalTable: "TrainingPlans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TrainingPlanUserTrainingPlans",
                columns: table => new
                {
                    TrainingPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserTrainingPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPlanUserTrainingPlans", x => new { x.TrainingPlanId, x.UserTrainingPlanId });
                    table.ForeignKey(
                        name: "FK_TrainingPlanUserTrainingPlans_TrainingPlans_TrainingPlanId",
                        column: x => x.TrainingPlanId,
                        principalTable: "TrainingPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingPlanUserTrainingPlans_UserTrainingPlans_UserTrainingPlanId",
                        column: x => x.UserTrainingPlanId,
                        principalTable: "UserTrainingPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: ""),
                    Price = table.Column<long>(type: "bigint", maxLength: 50, nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GeographicInfoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TypeOfNutritionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductServices_GeographicInfo_GeographicInfoId",
                        column: x => x.GeographicInfoId,
                        principalTable: "GeographicInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductServices_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductServices_ServiceType_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductServices_TypeOfNutrition_TypeOfNutritionId",
                        column: x => x.TypeOfNutritionId,
                        principalTable: "TypeOfNutrition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    Repeats = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<long>(type: "bigint", nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercises_Trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductServiceActivities",
                columns: table => new
                {
                    ProductServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductServiceActivities", x => new { x.ProductServiceId, x.ActivityId });
                    table.ForeignKey(
                        name: "FK_ProductServiceActivities_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductServiceActivities_ProductServices_ProductServiceId",
                        column: x => x.ProductServiceId,
                        principalTable: "ProductServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductServiceAllergies",
                columns: table => new
                {
                    ProductServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NutritionalAllergyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductServiceAllergies", x => new { x.ProductServiceId, x.NutritionalAllergyId });
                    table.ForeignKey(
                        name: "FK_ProductServiceAllergies_NutritionalAllergies_NutritionalAllergyId",
                        column: x => x.NutritionalAllergyId,
                        principalTable: "NutritionalAllergies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductServiceAllergies_ProductServices_ProductServiceId",
                        column: x => x.ProductServiceId,
                        principalTable: "ProductServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductServiceGoals",
                columns: table => new
                {
                    ProductServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductServiceGoals", x => new { x.ProductServiceId, x.GoalId });
                    table.ForeignKey(
                        name: "FK_ProductServiceGoals_Goals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductServiceGoals_ProductServices_ProductServiceId",
                        column: x => x.ProductServiceId,
                        principalTable: "ProductServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Enabled", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"), new DateTime(2024, 4, 2, 3, 10, 37, 868, DateTimeKind.Utc).AddTicks(7242), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), "This is the default category", true, "Default Category", new DateTime(2024, 4, 2, 3, 10, 37, 868, DateTimeKind.Utc).AddTicks(7247), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6") });

            migrationBuilder.InsertData(
                table: "Plans",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Enabled", "Name", "Price", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"), new DateTime(2024, 4, 2, 3, 10, 37, 869, DateTimeKind.Utc).AddTicks(3634), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), "Intermediate Plan", true, "Intermediate", 50L, new DateTime(2024, 4, 2, 3, 10, 37, 869, DateTimeKind.Utc).AddTicks(3634), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6") },
                    { new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"), new DateTime(2024, 4, 2, 3, 10, 37, 869, DateTimeKind.Utc).AddTicks(3630), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), "Basic Plan", true, "Basic", 0L, new DateTime(2024, 4, 2, 3, 10, 37, 869, DateTimeKind.Utc).AddTicks(3631), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6") },
                    { new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"), new DateTime(2024, 4, 2, 3, 10, 37, 869, DateTimeKind.Utc).AddTicks(3637), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), "Premium Plan", true, "Premium", 150L, new DateTime(2024, 4, 2, 3, 10, 37, 869, DateTimeKind.Utc).AddTicks(3637), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6") }
                });

            migrationBuilder.InsertData(
                table: "ServiceType",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Enabled", "Name", "Picture", "UpdatedAt", "UpdatedBy", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("93fc91b3-47dd-49e8-9589-01671491cc73"), new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5451), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), "Event Service Type", true, "Event", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fmeetings.skift.com%2Fselect-perfect-host-city-next-sporting-event%2F&psig=AOvVaw35cRcP9tZumnhT2O2yNcfm&ust=1712110352401000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCNik04zBooUDFQAAAAAdAAAAABAE", new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5451), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec") }
                });

            migrationBuilder.InsertData(
                table: "ServiceType",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Enabled", "Name", "Picture", "UpdatedAt", "UpdatedBy", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("555b7874-cf73-41ad-bbec-e517a646241c"), new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5451), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), "Product Service Type", true, "Product", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fmeetings.skift.com%2Fselect-perfect-host-city-next-sporting-event%2F&psig=AOvVaw35cRcP9tZumnhT2O2yNcfm&ust=1712110352401000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCNik04zBooUDFQAAAAAdAAAAABAE", new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5451), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_TrainingId",
                table: "Exercises",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductServiceActivities_ActivityId",
                table: "ProductServiceActivities",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductServiceAllergies_NutritionalAllergyId",
                table: "ProductServiceAllergies",
                column: "NutritionalAllergyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductServiceGoals_GoalId",
                table: "ProductServiceGoals",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductServices_GeographicInfoId",
                table: "ProductServices",
                column: "GeographicInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductServices_PlanId",
                table: "ProductServices",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductServices_ServiceTypeId",
                table: "ProductServices",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductServices_TypeOfNutritionId",
                table: "ProductServices",
                column: "TypeOfNutritionId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceType_CategoryId",
                table: "ServiceType",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlanActivities_ActivityId",
                table: "TrainingPlanActivities",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlanGoals_GoalId",
                table: "TrainingPlanGoals",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlanUserTrainingPlans_UserTrainingPlanId",
                table: "TrainingPlanUserTrainingPlans",
                column: "UserTrainingPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_TrainingPlanId",
                table: "Trainings",
                column: "TrainingPlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "ProductServiceActivities");

            migrationBuilder.DropTable(
                name: "ProductServiceAllergies");

            migrationBuilder.DropTable(
                name: "ProductServiceGoals");

            migrationBuilder.DropTable(
                name: "TrainingPlanActivities");

            migrationBuilder.DropTable(
                name: "TrainingPlanGoals");

            migrationBuilder.DropTable(
                name: "TrainingPlanUserTrainingPlans");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "NutritionalAllergies");

            migrationBuilder.DropTable(
                name: "ProductServices");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "UserTrainingPlans");

            migrationBuilder.DropTable(
                name: "TrainingPlans");

            migrationBuilder.DropTable(
                name: "GeographicInfo");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "ServiceType");

            migrationBuilder.DropTable(
                name: "TypeOfNutrition");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
