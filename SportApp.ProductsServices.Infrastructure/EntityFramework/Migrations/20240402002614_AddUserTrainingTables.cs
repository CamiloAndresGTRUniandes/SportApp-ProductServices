using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AddUserTrainingTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserTrainingPlan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTrainingPlan", x => x.Id);
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
                        name: "FK_TrainingPlanUserTrainingPlans_UserTrainingPlan_UserTrainingPlanId",
                        column: x => x.UserTrainingPlanId,
                        principalTable: "UserTrainingPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 26, 13, 69, DateTimeKind.Utc).AddTicks(5119), new DateTime(2024, 4, 2, 0, 26, 13, 69, DateTimeKind.Utc).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 26, 13, 70, DateTimeKind.Utc).AddTicks(1941), new DateTime(2024, 4, 2, 0, 26, 13, 70, DateTimeKind.Utc).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 26, 13, 70, DateTimeKind.Utc).AddTicks(1937), new DateTime(2024, 4, 2, 0, 26, 13, 70, DateTimeKind.Utc).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 26, 13, 70, DateTimeKind.Utc).AddTicks(1944), new DateTime(2024, 4, 2, 0, 26, 13, 70, DateTimeKind.Utc).AddTicks(1944) });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlanUserTrainingPlans_UserTrainingPlanId",
                table: "TrainingPlanUserTrainingPlans",
                column: "UserTrainingPlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainingPlanUserTrainingPlans");

            migrationBuilder.DropTable(
                name: "UserTrainingPlan");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 7, 49, 27, 815, DateTimeKind.Utc).AddTicks(6648), new DateTime(2024, 3, 31, 7, 49, 27, 815, DateTimeKind.Utc).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 7, 49, 27, 816, DateTimeKind.Utc).AddTicks(4140), new DateTime(2024, 3, 31, 7, 49, 27, 816, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 7, 49, 27, 816, DateTimeKind.Utc).AddTicks(4089), new DateTime(2024, 3, 31, 7, 49, 27, 816, DateTimeKind.Utc).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 7, 49, 27, 816, DateTimeKind.Utc).AddTicks(4143), new DateTime(2024, 3, 31, 7, 49, 27, 816, DateTimeKind.Utc).AddTicks(4144) });
        }
    }
}
