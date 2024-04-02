using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AddUserTrainingTablesPending : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPlanUserTrainingPlans_UserTrainingPlan_UserTrainingPlanId",
                table: "TrainingPlanUserTrainingPlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTrainingPlan",
                table: "UserTrainingPlan");

            migrationBuilder.DropColumn(
                name: "State",
                table: "UserTrainingPlan");

            migrationBuilder.RenameTable(
                name: "UserTrainingPlan",
                newName: "UserTrainingPlans");

            migrationBuilder.AlterColumn<bool>(
                name: "Enabled",
                table: "UserTrainingPlans",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<Guid>(
                name: "SubscribedUser",
                table: "UserTrainingPlans",
                type: "uniqueidentifier",
                maxLength: 36,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTrainingPlans",
                table: "UserTrainingPlans",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 34, 4, 179, DateTimeKind.Utc).AddTicks(1819), new DateTime(2024, 4, 2, 0, 34, 4, 179, DateTimeKind.Utc).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 34, 4, 179, DateTimeKind.Utc).AddTicks(8228), new DateTime(2024, 4, 2, 0, 34, 4, 179, DateTimeKind.Utc).AddTicks(8228) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 34, 4, 179, DateTimeKind.Utc).AddTicks(8224), new DateTime(2024, 4, 2, 0, 34, 4, 179, DateTimeKind.Utc).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 34, 4, 179, DateTimeKind.Utc).AddTicks(8231), new DateTime(2024, 4, 2, 0, 34, 4, 179, DateTimeKind.Utc).AddTicks(8231) });

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPlanUserTrainingPlans_UserTrainingPlans_UserTrainingPlanId",
                table: "TrainingPlanUserTrainingPlans",
                column: "UserTrainingPlanId",
                principalTable: "UserTrainingPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPlanUserTrainingPlans_UserTrainingPlans_UserTrainingPlanId",
                table: "TrainingPlanUserTrainingPlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTrainingPlans",
                table: "UserTrainingPlans");

            migrationBuilder.DropColumn(
                name: "SubscribedUser",
                table: "UserTrainingPlans");

            migrationBuilder.RenameTable(
                name: "UserTrainingPlans",
                newName: "UserTrainingPlan");

            migrationBuilder.AlterColumn<bool>(
                name: "Enabled",
                table: "UserTrainingPlan",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "UserTrainingPlan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTrainingPlan",
                table: "UserTrainingPlan",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPlanUserTrainingPlans_UserTrainingPlan_UserTrainingPlanId",
                table: "TrainingPlanUserTrainingPlans",
                column: "UserTrainingPlanId",
                principalTable: "UserTrainingPlan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
