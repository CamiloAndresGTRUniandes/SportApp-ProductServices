using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AddPlanDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Plans",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Enabled", "Name", "Price", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"), new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5451), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), "Intermediate Plan", true, "Intermediate", 50L, new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5451), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6") },
                    { new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"), new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5443), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), "Basic Plan", true, "Basic", 0L, new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5447), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6") },
                    { new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"), new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5454), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), "Premium Plan", true, "Premium", 150L, new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5454), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"));

            migrationBuilder.DeleteData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"));

            migrationBuilder.DeleteData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"));
        }
    }
}
