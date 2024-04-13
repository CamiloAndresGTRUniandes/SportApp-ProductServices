using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AlterCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ServiceType",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 9, 5, 7, 18, 19, DateTimeKind.Utc).AddTicks(1078), new DateTime(2024, 4, 9, 5, 7, 18, 19, DateTimeKind.Utc).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 9, 5, 7, 18, 19, DateTimeKind.Utc).AddTicks(8078), new DateTime(2024, 4, 9, 5, 7, 18, 19, DateTimeKind.Utc).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 9, 5, 7, 18, 19, DateTimeKind.Utc).AddTicks(8073), new DateTime(2024, 4, 9, 5, 7, 18, 19, DateTimeKind.Utc).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 9, 5, 7, 18, 19, DateTimeKind.Utc).AddTicks(8081), new DateTime(2024, 4, 9, 5, 7, 18, 19, DateTimeKind.Utc).AddTicks(8082) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ServiceType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 9, 4, 26, 45, 148, DateTimeKind.Utc).AddTicks(3007), new DateTime(2024, 4, 9, 4, 26, 45, 148, DateTimeKind.Utc).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 9, 4, 26, 45, 148, DateTimeKind.Utc).AddTicks(9641), new DateTime(2024, 4, 9, 4, 26, 45, 148, DateTimeKind.Utc).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 9, 4, 26, 45, 148, DateTimeKind.Utc).AddTicks(9636), new DateTime(2024, 4, 9, 4, 26, 45, 148, DateTimeKind.Utc).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 9, 4, 26, 45, 148, DateTimeKind.Utc).AddTicks(9644), new DateTime(2024, 4, 9, 4, 26, 45, 148, DateTimeKind.Utc).AddTicks(9644) });
        }
    }
}
