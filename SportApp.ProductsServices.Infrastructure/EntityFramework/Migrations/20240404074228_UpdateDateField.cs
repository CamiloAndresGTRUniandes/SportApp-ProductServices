using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDateField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 7, 42, 26, 799, DateTimeKind.Utc).AddTicks(1505), new DateTime(2024, 4, 4, 7, 42, 26, 799, DateTimeKind.Utc).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 7, 42, 26, 799, DateTimeKind.Utc).AddTicks(7889), new DateTime(2024, 4, 4, 7, 42, 26, 799, DateTimeKind.Utc).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 7, 42, 26, 799, DateTimeKind.Utc).AddTicks(7885), new DateTime(2024, 4, 4, 7, 42, 26, 799, DateTimeKind.Utc).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 7, 42, 26, 799, DateTimeKind.Utc).AddTicks(7892), new DateTime(2024, 4, 4, 7, 42, 26, 799, DateTimeKind.Utc).AddTicks(7892) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 5, 51, 0, 232, DateTimeKind.Utc).AddTicks(488), new DateTime(2024, 4, 4, 5, 51, 0, 232, DateTimeKind.Utc).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 5, 51, 0, 232, DateTimeKind.Utc).AddTicks(8612), new DateTime(2024, 4, 4, 5, 51, 0, 232, DateTimeKind.Utc).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 5, 51, 0, 232, DateTimeKind.Utc).AddTicks(8607), new DateTime(2024, 4, 4, 5, 51, 0, 232, DateTimeKind.Utc).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 5, 51, 0, 232, DateTimeKind.Utc).AddTicks(8615), new DateTime(2024, 4, 4, 5, 51, 0, 232, DateTimeKind.Utc).AddTicks(8615) });
        }
    }
}
