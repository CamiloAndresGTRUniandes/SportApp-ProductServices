using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 9, 5, 11, 52, 751, DateTimeKind.Utc).AddTicks(4403), new DateTime(2024, 4, 9, 5, 11, 52, 751, DateTimeKind.Utc).AddTicks(4405) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Enabled", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("60d40a85-78ca-4b75-b75f-76cee4896ead"), new DateTime(2024, 4, 9, 5, 11, 52, 751, DateTimeKind.Utc).AddTicks(4413), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), "Categoría para servicios de todo tipo", true, "Servicios", new DateTime(2024, 4, 9, 5, 11, 52, 751, DateTimeKind.Utc).AddTicks(4413), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6") },
                    { new Guid("a649e6a9-f667-4e73-b8b6-3816c7e554eb"), new DateTime(2024, 4, 9, 5, 11, 52, 751, DateTimeKind.Utc).AddTicks(4410), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), "Categoría para productos de todo tipo", true, "Productos", new DateTime(2024, 4, 9, 5, 11, 52, 751, DateTimeKind.Utc).AddTicks(4411), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6") },
                    { new Guid("be8e2306-8bc9-49cc-8d43-a76820370994"), new DateTime(2024, 4, 9, 5, 11, 52, 751, DateTimeKind.Utc).AddTicks(4408), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), "Categoría para eventos de todo tipo", true, "Eventos", new DateTime(2024, 4, 9, 5, 11, 52, 751, DateTimeKind.Utc).AddTicks(4408), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6") }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60d40a85-78ca-4b75-b75f-76cee4896ead"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a649e6a9-f667-4e73-b8b6-3816c7e554eb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be8e2306-8bc9-49cc-8d43-a76820370994"));

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
    }
}
