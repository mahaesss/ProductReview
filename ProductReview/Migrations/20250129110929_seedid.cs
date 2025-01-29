using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductReview.Migrations
{
    /// <inheritdoc />
    public partial class seedid : Migration
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "9bbd8334-19ef-49a8-933a-0d99a755e0b7", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGd2Beyrqxuz+i2ZJ4O0qHCGpj5lSLyN/EQU5i1E13pq4Ltt+Yqesqfkmelv6YkFqQ==", null, false, "73f7fd5d-0b17-42ba-ba2a-c130a8585274", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 29, 19, 9, 26, 935, DateTimeKind.Local).AddTicks(4599), new DateTime(2025, 1, 29, 19, 9, 26, 935, DateTimeKind.Local).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 29, 19, 9, 26, 935, DateTimeKind.Local).AddTicks(4636), new DateTime(2025, 1, 29, 19, 9, 26, 935, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 29, 19, 9, 26, 935, DateTimeKind.Local).AddTicks(5329), new DateTime(2025, 1, 29, 19, 9, 26, 935, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 29, 19, 9, 26, 935, DateTimeKind.Local).AddTicks(5339), new DateTime(2025, 1, 29, 19, 9, 26, 935, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 29, 19, 9, 26, 935, DateTimeKind.Local).AddTicks(5651), new DateTime(2025, 1, 29, 19, 9, 26, 935, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 29, 19, 9, 26, 935, DateTimeKind.Local).AddTicks(5659), new DateTime(2025, 1, 29, 19, 9, 26, 935, DateTimeKind.Local).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 29, 19, 9, 26, 935, DateTimeKind.Local).AddTicks(5664), new DateTime(2025, 1, 29, 19, 9, 26, 935, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 29, 19, 9, 26, 935, DateTimeKind.Local).AddTicks(5670), new DateTime(2025, 1, 29, 19, 9, 26, 935, DateTimeKind.Local).AddTicks(5672) });

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
                values: new object[] { new DateTime(2025, 1, 29, 18, 29, 22, 632, DateTimeKind.Local).AddTicks(3852), new DateTime(2025, 1, 29, 18, 29, 22, 632, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 29, 18, 29, 22, 632, DateTimeKind.Local).AddTicks(3881), new DateTime(2025, 1, 29, 18, 29, 22, 632, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 29, 18, 29, 22, 632, DateTimeKind.Local).AddTicks(4565), new DateTime(2025, 1, 29, 18, 29, 22, 632, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 29, 18, 29, 22, 632, DateTimeKind.Local).AddTicks(4574), new DateTime(2025, 1, 29, 18, 29, 22, 632, DateTimeKind.Local).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 29, 18, 29, 22, 632, DateTimeKind.Local).AddTicks(4851), new DateTime(2025, 1, 29, 18, 29, 22, 632, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 29, 18, 29, 22, 632, DateTimeKind.Local).AddTicks(4859), new DateTime(2025, 1, 29, 18, 29, 22, 632, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 29, 18, 29, 22, 632, DateTimeKind.Local).AddTicks(4866), new DateTime(2025, 1, 29, 18, 29, 22, 632, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 29, 18, 29, 22, 632, DateTimeKind.Local).AddTicks(4872), new DateTime(2025, 1, 29, 18, 29, 22, 632, DateTimeKind.Local).AddTicks(4873) });
        }
    }
}
