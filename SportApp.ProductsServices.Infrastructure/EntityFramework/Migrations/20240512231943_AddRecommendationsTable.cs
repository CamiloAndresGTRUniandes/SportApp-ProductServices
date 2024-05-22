using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AddRecommendationsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recommendations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recommendations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recommendations_ProductServices_ProductServiceId",
                        column: x => x.ProductServiceId,
                        principalTable: "ProductServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03388722-321f-4b6a-963e-104eb73d17c2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 23, 19, 41, 964, DateTimeKind.Utc).AddTicks(2265), new DateTime(2024, 5, 12, 23, 19, 41, 964, DateTimeKind.Utc).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60d40a85-78ca-4b75-b75f-76cee4896ead"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 23, 19, 41, 964, DateTimeKind.Utc).AddTicks(2262), new DateTime(2024, 5, 12, 23, 19, 41, 964, DateTimeKind.Utc).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a649e6a9-f667-4e73-b8b6-3816c7e554eb"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 23, 19, 41, 964, DateTimeKind.Utc).AddTicks(2259), new DateTime(2024, 5, 12, 23, 19, 41, 964, DateTimeKind.Utc).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 23, 19, 41, 964, DateTimeKind.Utc).AddTicks(2251), new DateTime(2024, 5, 12, 23, 19, 41, 964, DateTimeKind.Utc).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be8e2306-8bc9-49cc-8d43-a76820370994"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 23, 19, 41, 964, DateTimeKind.Utc).AddTicks(2257), new DateTime(2024, 5, 12, 23, 19, 41, 964, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 23, 19, 41, 964, DateTimeKind.Utc).AddTicks(9974), new DateTime(2024, 5, 12, 23, 19, 41, 964, DateTimeKind.Utc).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 23, 19, 41, 964, DateTimeKind.Utc).AddTicks(9970), new DateTime(2024, 5, 12, 23, 19, 41, 964, DateTimeKind.Utc).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 23, 19, 41, 964, DateTimeKind.Utc).AddTicks(9977), new DateTime(2024, 5, 12, 23, 19, 41, 964, DateTimeKind.Utc).AddTicks(9977) });

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_ProductServiceId",
                table: "Recommendations",
                column: "ProductServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recommendations");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03388722-321f-4b6a-963e-104eb73d17c2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1275), new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60d40a85-78ca-4b75-b75f-76cee4896ead"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1272), new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a649e6a9-f667-4e73-b8b6-3816c7e554eb"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1269), new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1261), new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be8e2306-8bc9-49cc-8d43-a76820370994"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1266), new DateTime(2024, 5, 5, 4, 50, 58, 918, DateTimeKind.Utc).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 50, 58, 919, DateTimeKind.Utc).AddTicks(261), new DateTime(2024, 5, 5, 4, 50, 58, 919, DateTimeKind.Utc).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 50, 58, 919, DateTimeKind.Utc).AddTicks(255), new DateTime(2024, 5, 5, 4, 50, 58, 919, DateTimeKind.Utc).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 50, 58, 919, DateTimeKind.Utc).AddTicks(264), new DateTime(2024, 5, 5, 4, 50, 58, 919, DateTimeKind.Utc).AddTicks(264) });
        }
    }
}
