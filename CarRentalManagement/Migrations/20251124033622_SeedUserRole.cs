using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "4df40b41-9a4d-4582-b067-502b344433db", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAECxhVL7uFBZkj7WaGkauaGtoLHrkQZfKsxF8TV/c/Fy67J1wMcqeu1BHDwfteRhDJA==", null, false, "e6eabf9d-f576-4ceb-87c6-a2751dac0b8c", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 36, 21, 642, DateTimeKind.Local).AddTicks(4446), new DateTime(2025, 11, 24, 11, 36, 21, 642, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 36, 21, 642, DateTimeKind.Local).AddTicks(4464), new DateTime(2025, 11, 24, 11, 36, 21, 642, DateTimeKind.Local).AddTicks(4464) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 36, 21, 642, DateTimeKind.Local).AddTicks(4680), new DateTime(2025, 11, 24, 11, 36, 21, 642, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 36, 21, 642, DateTimeKind.Local).AddTicks(4682), new DateTime(2025, 11, 24, 11, 36, 21, 642, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 36, 21, 642, DateTimeKind.Local).AddTicks(4781), new DateTime(2025, 11, 24, 11, 36, 21, 642, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 36, 21, 642, DateTimeKind.Local).AddTicks(4783), new DateTime(2025, 11, 24, 11, 36, 21, 642, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 36, 21, 642, DateTimeKind.Local).AddTicks(4784), new DateTime(2025, 11, 24, 11, 36, 21, 642, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 36, 21, 642, DateTimeKind.Local).AddTicks(4786), new DateTime(2025, 11, 24, 11, 36, 21, 642, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 30, 25, 515, DateTimeKind.Local).AddTicks(2934), new DateTime(2025, 11, 24, 11, 30, 25, 515, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 30, 25, 515, DateTimeKind.Local).AddTicks(2952), new DateTime(2025, 11, 24, 11, 30, 25, 515, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 30, 25, 515, DateTimeKind.Local).AddTicks(3162), new DateTime(2025, 11, 24, 11, 30, 25, 515, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 30, 25, 515, DateTimeKind.Local).AddTicks(3165), new DateTime(2025, 11, 24, 11, 30, 25, 515, DateTimeKind.Local).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 30, 25, 515, DateTimeKind.Local).AddTicks(3268), new DateTime(2025, 11, 24, 11, 30, 25, 515, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 30, 25, 515, DateTimeKind.Local).AddTicks(3270), new DateTime(2025, 11, 24, 11, 30, 25, 515, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 30, 25, 515, DateTimeKind.Local).AddTicks(3271), new DateTime(2025, 11, 24, 11, 30, 25, 515, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 30, 25, 515, DateTimeKind.Local).AddTicks(3273), new DateTime(2025, 11, 24, 11, 30, 25, 515, DateTimeKind.Local).AddTicks(3273) });
        }
    }
}
