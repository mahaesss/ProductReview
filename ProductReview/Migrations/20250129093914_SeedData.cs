using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductReview.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 29, 17, 39, 12, 861, DateTimeKind.Local).AddTicks(103), new DateTime(2025, 1, 29, 17, 39, 12, 861, DateTimeKind.Local).AddTicks(120), "Black", "System" },
                    { 2, "System", new DateTime(2025, 1, 29, 17, 39, 12, 861, DateTimeKind.Local).AddTicks(125), new DateTime(2025, 1, 29, 17, 39, 12, 861, DateTimeKind.Local).AddTicks(126), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 29, 17, 39, 12, 861, DateTimeKind.Local).AddTicks(519), new DateTime(2025, 1, 29, 17, 39, 12, 861, DateTimeKind.Local).AddTicks(520), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 1, 29, 17, 39, 12, 861, DateTimeKind.Local).AddTicks(525), new DateTime(2025, 1, 29, 17, 39, 12, 861, DateTimeKind.Local).AddTicks(526), "Toyata", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 29, 17, 39, 12, 861, DateTimeKind.Local).AddTicks(764), new DateTime(2025, 1, 29, 17, 39, 12, 861, DateTimeKind.Local).AddTicks(767), "i4", "System" },
                    { 2, "System", new DateTime(2025, 1, 29, 17, 39, 12, 861, DateTimeKind.Local).AddTicks(771), new DateTime(2025, 1, 29, 17, 39, 12, 861, DateTimeKind.Local).AddTicks(772), "x5", "System" },
                    { 3, "System", new DateTime(2025, 1, 29, 17, 39, 12, 861, DateTimeKind.Local).AddTicks(774), new DateTime(2025, 1, 29, 17, 39, 12, 861, DateTimeKind.Local).AddTicks(775), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 1, 29, 17, 39, 12, 861, DateTimeKind.Local).AddTicks(778), new DateTime(2025, 1, 29, 17, 39, 12, 861, DateTimeKind.Local).AddTicks(779), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

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
        }
    }
}
