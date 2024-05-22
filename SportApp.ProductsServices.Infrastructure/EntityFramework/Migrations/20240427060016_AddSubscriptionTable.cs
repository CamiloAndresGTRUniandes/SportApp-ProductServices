using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AddSubscriptionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: false),
                    PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_PlanId",
                table: "Subscriptions",
                column: "PlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03388722-321f-4b6a-963e-104eb73d17c2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 21, 6, 17, 2, 173, DateTimeKind.Utc).AddTicks(1262), new DateTime(2024, 4, 21, 6, 17, 2, 173, DateTimeKind.Utc).AddTicks(1262) });

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
        }
    }
}
