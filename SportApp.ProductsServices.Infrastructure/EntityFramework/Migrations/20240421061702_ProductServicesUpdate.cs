using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class ProductServicesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "NutritionalPlanId",
                table: "ProductServices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60d40a85-78ca-4b75-b75f-76cee4896ead"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 21, 6, 17, 2, 173, DateTimeKind.Utc).AddTicks(1259), new DateTime(2024, 4, 21, 6, 17, 2, 173, DateTimeKind.Utc).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a649e6a9-f667-4e73-b8b6-3816c7e554eb"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 21, 6, 17, 2, 173, DateTimeKind.Utc).AddTicks(1256), new DateTime(2024, 4, 21, 6, 17, 2, 173, DateTimeKind.Utc).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 21, 6, 17, 2, 173, DateTimeKind.Utc).AddTicks(1248), new DateTime(2024, 4, 21, 6, 17, 2, 173, DateTimeKind.Utc).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be8e2306-8bc9-49cc-8d43-a76820370994"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 21, 6, 17, 2, 173, DateTimeKind.Utc).AddTicks(1253), new DateTime(2024, 4, 21, 6, 17, 2, 173, DateTimeKind.Utc).AddTicks(1253) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Enabled", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("03388722-321f-4b6a-963e-104eb73d17c2"), new DateTime(2024, 4, 21, 6, 17, 2, 173, DateTimeKind.Utc).AddTicks(1262), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), "Categoría para planes de todo tipo", true, "Planes", new DateTime(2024, 4, 21, 6, 17, 2, 173, DateTimeKind.Utc).AddTicks(1262), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6") });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 21, 6, 17, 2, 173, DateTimeKind.Utc).AddTicks(8055), new DateTime(2024, 4, 21, 6, 17, 2, 173, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 21, 6, 17, 2, 173, DateTimeKind.Utc).AddTicks(8051), new DateTime(2024, 4, 21, 6, 17, 2, 173, DateTimeKind.Utc).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 21, 6, 17, 2, 173, DateTimeKind.Utc).AddTicks(8058), new DateTime(2024, 4, 21, 6, 17, 2, 173, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductServices_NutritionalPlanId",
                table: "ProductServices",
                column: "NutritionalPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductServices_NutritionalPlans_NutritionalPlanId",
                table: "ProductServices",
                column: "NutritionalPlanId",
                principalTable: "NutritionalPlans",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductServices_NutritionalPlans_NutritionalPlanId",
                table: "ProductServices");

            migrationBuilder.DropIndex(
                name: "IX_ProductServices_NutritionalPlanId",
                table: "ProductServices");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03388722-321f-4b6a-963e-104eb73d17c2"));

            migrationBuilder.DropColumn(
                name: "NutritionalPlanId",
                table: "ProductServices");

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
        }
    }
}
