using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AlterTrainingtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "TrainingPlans");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "TrainingPlans");

            migrationBuilder.DropColumn(
                name: "SportLevel",
                table: "TrainingPlans");

            migrationBuilder.AddColumn<Guid>(
                name: "TrainingPlanId",
                table: "ProductServices",
                type: "uniqueidentifier",
                nullable: true);

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
                name: "IX_ProductServices_TrainingPlanId",
                table: "ProductServices",
                column: "TrainingPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductServices_TrainingPlans_TrainingPlanId",
                table: "ProductServices",
                column: "TrainingPlanId",
                principalTable: "TrainingPlans",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductServices_TrainingPlans_TrainingPlanId",
                table: "ProductServices");

            migrationBuilder.DropIndex(
                name: "IX_ProductServices_TrainingPlanId",
                table: "ProductServices");

            migrationBuilder.DropColumn(
                name: "TrainingPlanId",
                table: "ProductServices");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TrainingPlans",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TrainingPlans",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SportLevel",
                table: "TrainingPlans",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03388722-321f-4b6a-963e-104eb73d17c2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 6, 0, 14, 558, DateTimeKind.Utc).AddTicks(6336), new DateTime(2024, 4, 27, 6, 0, 14, 558, DateTimeKind.Utc).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60d40a85-78ca-4b75-b75f-76cee4896ead"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 6, 0, 14, 558, DateTimeKind.Utc).AddTicks(6334), new DateTime(2024, 4, 27, 6, 0, 14, 558, DateTimeKind.Utc).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a649e6a9-f667-4e73-b8b6-3816c7e554eb"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 6, 0, 14, 558, DateTimeKind.Utc).AddTicks(6331), new DateTime(2024, 4, 27, 6, 0, 14, 558, DateTimeKind.Utc).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 6, 0, 14, 558, DateTimeKind.Utc).AddTicks(6323), new DateTime(2024, 4, 27, 6, 0, 14, 558, DateTimeKind.Utc).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be8e2306-8bc9-49cc-8d43-a76820370994"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 6, 0, 14, 558, DateTimeKind.Utc).AddTicks(6328), new DateTime(2024, 4, 27, 6, 0, 14, 558, DateTimeKind.Utc).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 6, 0, 14, 559, DateTimeKind.Utc).AddTicks(5079), new DateTime(2024, 4, 27, 6, 0, 14, 559, DateTimeKind.Utc).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 6, 0, 14, 559, DateTimeKind.Utc).AddTicks(5075), new DateTime(2024, 4, 27, 6, 0, 14, 559, DateTimeKind.Utc).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 6, 0, 14, 559, DateTimeKind.Utc).AddTicks(5082), new DateTime(2024, 4, 27, 6, 0, 14, 559, DateTimeKind.Utc).AddTicks(5083) });
        }
    }
}
