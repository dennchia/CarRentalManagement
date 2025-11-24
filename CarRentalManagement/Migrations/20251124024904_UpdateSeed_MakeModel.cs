using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeed_MakeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 10, 49, 4, 62, DateTimeKind.Local).AddTicks(81), new DateTime(2025, 11, 24, 10, 49, 4, 62, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 10, 49, 4, 62, DateTimeKind.Local).AddTicks(98), new DateTime(2025, 11, 24, 10, 49, 4, 62, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 10, 49, 4, 62, DateTimeKind.Local).AddTicks(353), new DateTime(2025, 11, 24, 10, 49, 4, 62, DateTimeKind.Local).AddTicks(355), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 10, 49, 4, 62, DateTimeKind.Local).AddTicks(356), new DateTime(2025, 11, 24, 10, 49, 4, 62, DateTimeKind.Local).AddTicks(357), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 10, 49, 4, 62, DateTimeKind.Local).AddTicks(530), new DateTime(2025, 11, 24, 10, 49, 4, 62, DateTimeKind.Local).AddTicks(531), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 10, 49, 4, 62, DateTimeKind.Local).AddTicks(533), new DateTime(2025, 11, 24, 10, 49, 4, 62, DateTimeKind.Local).AddTicks(533), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 10, 49, 4, 62, DateTimeKind.Local).AddTicks(534), new DateTime(2025, 11, 24, 10, 49, 4, 62, DateTimeKind.Local).AddTicks(534), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 10, 49, 4, 62, DateTimeKind.Local).AddTicks(535), new DateTime(2025, 11, 24, 10, 49, 4, 62, DateTimeKind.Local).AddTicks(536), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 10, 32, 47, 532, DateTimeKind.Local).AddTicks(4789), new DateTime(2025, 11, 24, 10, 32, 47, 532, DateTimeKind.Local).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 10, 32, 47, 532, DateTimeKind.Local).AddTicks(4805), new DateTime(2025, 11, 24, 10, 32, 47, 532, DateTimeKind.Local).AddTicks(4805) });
        }
    }
}
