using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AlterRelationProductAllergies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductServiceAllergies");

            migrationBuilder.CreateTable(
                name: "ProductServiceNutritionalAllergies",
                columns: table => new
                {
                    ProductServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NutritionalAllergyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductServiceNutritionalAllergies", x => new { x.ProductServiceId, x.NutritionalAllergyId });
                    table.ForeignKey(
                        name: "FK_ProductServiceNutritionalAllergies_NutritionalAllergies_NutritionalAllergyId",
                        column: x => x.NutritionalAllergyId,
                        principalTable: "NutritionalAllergies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductServiceNutritionalAllergies_ProductServices_ProductServiceId",
                        column: x => x.ProductServiceId,
                        principalTable: "ProductServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductServiceNutritionalAllergies_NutritionalAllergyId",
                table: "ProductServiceNutritionalAllergies",
                column: "NutritionalAllergyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductServiceNutritionalAllergies");

            migrationBuilder.CreateTable(
                name: "ProductServiceAllergies",
                columns: table => new
                {
                    ProductServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NutritionalAllergyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductServiceAllergies", x => new { x.ProductServiceId, x.NutritionalAllergyId });
                    table.ForeignKey(
                        name: "FK_ProductServiceAllergies_NutritionalAllergies_NutritionalAllergyId",
                        column: x => x.NutritionalAllergyId,
                        principalTable: "NutritionalAllergies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductServiceAllergies_ProductServices_ProductServiceId",
                        column: x => x.ProductServiceId,
                        principalTable: "ProductServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 8, 7, 13, 6, 763, DateTimeKind.Utc).AddTicks(4751), new DateTime(2024, 4, 8, 7, 13, 6, 763, DateTimeKind.Utc).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 8, 7, 13, 6, 764, DateTimeKind.Utc).AddTicks(1516), new DateTime(2024, 4, 8, 7, 13, 6, 764, DateTimeKind.Utc).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 8, 7, 13, 6, 764, DateTimeKind.Utc).AddTicks(1509), new DateTime(2024, 4, 8, 7, 13, 6, 764, DateTimeKind.Utc).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 8, 7, 13, 6, 764, DateTimeKind.Utc).AddTicks(1519), new DateTime(2024, 4, 8, 7, 13, 6, 764, DateTimeKind.Utc).AddTicks(1519) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductServiceAllergies_NutritionalAllergyId",
                table: "ProductServiceAllergies",
                column: "NutritionalAllergyId");
        }
    }
}
