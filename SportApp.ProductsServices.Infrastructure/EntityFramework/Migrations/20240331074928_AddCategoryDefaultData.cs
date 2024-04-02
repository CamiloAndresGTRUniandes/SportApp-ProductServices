using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportApp.ProductsServices.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Enabled", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"), new DateTime(2024, 3, 31, 7, 49, 27, 815, DateTimeKind.Utc).AddTicks(6648), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), "This is the default category", true, "Default Category", new DateTime(2024, 3, 31, 7, 49, 27, 815, DateTimeKind.Utc).AddTicks(6650), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6") });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 7, 49, 27, 816, DateTimeKind.Utc).AddTicks(4140), new DateTime(2024, 3, 31, 7, 49, 27, 816, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 7, 49, 27, 816, DateTimeKind.Utc).AddTicks(4089), new DateTime(2024, 3, 31, 7, 49, 27, 816, DateTimeKind.Utc).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 7, 49, 27, 816, DateTimeKind.Utc).AddTicks(4143), new DateTime(2024, 3, 31, 7, 49, 27, 816, DateTimeKind.Utc).AddTicks(4144) });
            
            migrationBuilder.InsertData(
                table: "ServiceType",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Enabled", "Name", "Picture", "UpdatedAt", "UpdatedBy", "CategoryId" },
                values: new object[,]
                    {
                        { new Guid("93fc91b3-47dd-49e8-9589-01671491cc73"), new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5451), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), "Event Service Type", true, "Event", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fmeetings.skift.com%2Fselect-perfect-host-city-next-sporting-event%2F&psig=AOvVaw35cRcP9tZumnhT2O2yNcfm&ust=1712110352401000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCNik04zBooUDFQAAAAAdAAAAABAE", new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5451), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec") }
                    });

            migrationBuilder.InsertData(
                table: "ServiceType",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Enabled", "Name", "Picture", "UpdatedAt", "UpdatedBy", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("555b7874-cf73-41ad-bbec-e517a646241c"), new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5451), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), "Product Service Type", true, "Product", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fmeetings.skift.com%2Fselect-perfect-host-city-next-sporting-event%2F&psig=AOvVaw35cRcP9tZumnhT2O2yNcfm&ust=1712110352401000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCNik04zBooUDFQAAAAAdAAAAABAE", new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5451), new Guid("3bfc0e87-e3bb-46b4-9f0a-b0d264fcd6b6"), new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec") }
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56a2dd5-fbca-4892-9a4e-b621c40f83ec"));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("2c312559-173d-4239-a03d-2fdb3f219fa5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5451), new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("672d4087-ac82-42b5-846e-64905d1a09b3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5443), new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: new Guid("7ee7db76-77c2-4353-a509-ebe4fbe4aed4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5454), new DateTime(2024, 3, 31, 7, 45, 51, 554, DateTimeKind.Utc).AddTicks(5454) });
        }
    }
}
