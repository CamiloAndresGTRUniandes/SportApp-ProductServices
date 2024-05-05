using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AlterTrainingtablesRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainingPlanActivities");

            migrationBuilder.DropTable(
                name: "TrainingPlanGoals");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03388722-321f-4b6a-963e-104eb73d17c2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1275), new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60d40a85-78ca-4b75-b75f-76cee4896ead"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1272), new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a649e6a9-f667-4e73-b8b6-3816c7e554eb"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1269), new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1261), new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be8e2306-8bc9-49cc-8d43-a76820370994"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1266), new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 50, 58, 919, DateTimeKind.Utc).AddTicks(261), new DateTime(2024, 5, 5, 4, 50, 58, 919, DateTimeKind.Utc).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 50, 58, 919, DateTimeKind.Utc).AddTicks(255), new DateTime(2024, 5, 5, 4, 50, 58, 919, DateTimeKind.Utc).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 50, 58, 919, DateTimeKind.Utc).AddTicks(264), new DateTime(2024, 5, 5, 4, 50, 58, 919, DateTimeKind.Utc).AddTicks(264) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03388722-321f-4b6a-963e-104eb73d17c2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 3, 57, 29, 114, DateTimeKind.Utc).AddTicks(2830), new DateTime(2024, 5, 5, 3, 57, 29, 114, DateTimeKind.Utc).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60d40a85-78ca-4b75-b75f-76cee4896ead"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 3, 57, 29, 114, DateTimeKind.Utc).AddTicks(2826), new DateTime(2024, 5, 5, 3, 57, 29, 114, DateTimeKind.Utc).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a649e6a9-f667-4e73-b8b6-3816c7e554eb"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 3, 57, 29, 114, DateTimeKind.Utc).AddTicks(2824), new DateTime(2024, 5, 5, 3, 57, 29, 114, DateTimeKind.Utc).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 3, 57, 29, 114, DateTimeKind.Utc).AddTicks(2816), new DateTime(2024, 5, 5, 3, 57, 29, 114, DateTimeKind.Utc).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be8e2306-8bc9-49cc-8d43-a76820370994"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 3, 57, 29, 114, DateTimeKind.Utc).AddTicks(2821), new DateTime(2024, 5, 5, 3, 57, 29, 114, DateTimeKind.Utc).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 3, 57, 29, 115, DateTimeKind.Utc).AddTicks(1568), new DateTime(2024, 5, 5, 3, 57, 29, 115, DateTimeKind.Utc).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 3, 57, 29, 115, DateTimeKind.Utc).AddTicks(1563), new DateTime(2024, 5, 5, 3, 57, 29, 115, DateTimeKind.Utc).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 3, 57, 29, 115, DateTimeKind.Utc).AddTicks(1571), new DateTime(2024, 5, 5, 3, 57, 29, 115, DateTimeKind.Utc).AddTicks(1571) });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlanActivities_ActivityId",
                table: "TrainingPlanActivities",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlanGoals_GoalId",
                table: "TrainingPlanGoals",
                column: "GoalId");
        }
    }
}
