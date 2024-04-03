using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AddDateRangeProductService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDateTime",
                table: "ProductServices",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StarDateTime",
                table: "ProductServices",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 3, 6, 54, 38, 525, DateTimeKind.Utc).AddTicks(408), new DateTime(2024, 4, 3, 6, 54, 38, 525, DateTimeKind.Utc).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 3, 6, 54, 38, 525, DateTimeKind.Utc).AddTicks(7176), new DateTime(2024, 4, 3, 6, 54, 38, 525, DateTimeKind.Utc).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 3, 6, 54, 38, 525, DateTimeKind.Utc).AddTicks(7170), new DateTime(2024, 4, 3, 6, 54, 38, 525, DateTimeKind.Utc).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 3, 6, 54, 38, 525, DateTimeKind.Utc).AddTicks(7180), new DateTime(2024, 4, 3, 6, 54, 38, 525, DateTimeKind.Utc).AddTicks(7180) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDateTime",
                table: "ProductServices");

            migrationBuilder.DropColumn(
                name: "StarDateTime",
                table: "ProductServices");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 3, 10, 37, 868, DateTimeKind.Utc).AddTicks(7242), new DateTime(2024, 4, 2, 3, 10, 37, 868, DateTimeKind.Utc).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 3, 10, 37, 869, DateTimeKind.Utc).AddTicks(3634), new DateTime(2024, 4, 2, 3, 10, 37, 869, DateTimeKind.Utc).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 3, 10, 37, 869, DateTimeKind.Utc).AddTicks(3630), new DateTime(2024, 4, 2, 3, 10, 37, 869, DateTimeKind.Utc).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 3, 10, 37, 869, DateTimeKind.Utc).AddTicks(3637), new DateTime(2024, 4, 2, 3, 10, 37, 869, DateTimeKind.Utc).AddTicks(3637) });
        }
    }
}
