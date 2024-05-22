using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AddNutritionalPlans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NutritionalPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionalPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserNutritionalPlan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscribedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityState = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNutritionalPlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NutritionalPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Days_NutritionalPlans_NutritionalPlanId",
                        column: x => x.NutritionalPlanId,
                        principalTable: "NutritionalPlans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NutritionalPlanGoals",
                columns: table => new
                {
                    NutritionalPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionalPlanGoals", x => new { x.NutritionalPlanId, x.GoalId });
                    table.ForeignKey(
                        name: "FK_NutritionalPlanGoals_Goals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NutritionalPlanGoals_NutritionalPlans_NutritionalPlanId",
                        column: x => x.NutritionalPlanId,
                        principalTable: "NutritionalPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NutritionalPlanUserNutritionalPlans",
                columns: table => new
                {
                    NutritionalPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserNutritionalPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionalPlanUserNutritionalPlans", x => new { x.NutritionalPlanId, x.UserNutritionalPlanId });
                    table.ForeignKey(
                        name: "FK_NutritionalPlanUserNutritionalPlans_NutritionalPlans_NutritionalPlanId",
                        column: x => x.NutritionalPlanId,
                        principalTable: "NutritionalPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NutritionalPlanUserNutritionalPlans_UserNutritionalPlan_UserNutritionalPlanId",
                        column: x => x.UserNutritionalPlanId,
                        principalTable: "UserNutritionalPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    DishType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meals_Days_DayId",
                        column: x => x.DayId,
                        principalTable: "Days",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60d40a85-78ca-4b75-b75f-76cee4896ead"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 59, 58, 341, DateTimeKind.Utc).AddTicks(1113), new DateTime(2024, 4, 20, 6, 59, 58, 341, DateTimeKind.Utc).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a649e6a9-f667-4e73-b8b6-3816c7e554eb"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 59, 58, 341, DateTimeKind.Utc).AddTicks(1111), new DateTime(2024, 4, 20, 6, 59, 58, 341, DateTimeKind.Utc).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 59, 58, 341, DateTimeKind.Utc).AddTicks(1101), new DateTime(2024, 4, 20, 6, 59, 58, 341, DateTimeKind.Utc).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be8e2306-8bc9-49cc-8d43-a76820370994"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 59, 58, 341, DateTimeKind.Utc).AddTicks(1108), new DateTime(2024, 4, 20, 6, 59, 58, 341, DateTimeKind.Utc).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 59, 58, 341, DateTimeKind.Utc).AddTicks(7635), new DateTime(2024, 4, 20, 6, 59, 58, 341, DateTimeKind.Utc).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 59, 58, 341, DateTimeKind.Utc).AddTicks(7631), new DateTime(2024, 4, 20, 6, 59, 58, 341, DateTimeKind.Utc).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 59, 58, 341, DateTimeKind.Utc).AddTicks(7638), new DateTime(2024, 4, 20, 6, 59, 58, 341, DateTimeKind.Utc).AddTicks(7638) });

            migrationBuilder.CreateIndex(
                name: "IX_Days_NutritionalPlanId",
                table: "Days",
                column: "NutritionalPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_DayId",
                table: "Meals",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_NutritionalPlanGoals_GoalId",
                table: "NutritionalPlanGoals",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_NutritionalPlanUserNutritionalPlans_UserNutritionalPlanId",
                table: "NutritionalPlanUserNutritionalPlans",
                column: "UserNutritionalPlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "NutritionalPlanGoals");

            migrationBuilder.DropTable(
                name: "NutritionalPlanUserNutritionalPlans");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "UserNutritionalPlan");

            migrationBuilder.DropTable(
                name: "NutritionalPlans");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60d40a85-78ca-4b75-b75f-76cee4896ead"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 9, 5, 11, 52, 751, DateTimeKind.Utc).AddTicks(4413), new DateTime(2024, 4, 9, 5, 11, 52, 751, DateTimeKind.Utc).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a649e6a9-f667-4e73-b8b6-3816c7e554eb"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 9, 5, 11, 52, 751, DateTimeKind.Utc).AddTicks(4410), new DateTime(2024, 4, 9, 5, 11, 52, 751, DateTimeKind.Utc).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 9, 5, 11, 52, 751, DateTimeKind.Utc).AddTicks(4403), new DateTime(2024, 4, 9, 5, 11, 52, 751, DateTimeKind.Utc).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be8e2306-8bc9-49cc-8d43-a76820370994"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 9, 5, 11, 52, 751, DateTimeKind.Utc).AddTicks(4408), new DateTime(2024, 4, 9, 5, 11, 52, 751, DateTimeKind.Utc).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 9, 5, 11, 52, 752, DateTimeKind.Utc).AddTicks(1437), new DateTime(2024, 4, 9, 5, 11, 52, 752, DateTimeKind.Utc).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 9, 5, 11, 52, 752, DateTimeKind.Utc).AddTicks(1432), new DateTime(2024, 4, 9, 5, 11, 52, 752, DateTimeKind.Utc).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 9, 5, 11, 52, 752, DateTimeKind.Utc).AddTicks(1440), new DateTime(2024, 4, 9, 5, 11, 52, 752, DateTimeKind.Utc).AddTicks(1440) });
        }
    }
}
