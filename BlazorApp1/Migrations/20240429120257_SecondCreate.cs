using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "Id", "Description", "DueDate", "IsCompleted" },
                values: new object[,]
                {
                    { 1, "Complete All Coded Assignments", new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 2, "Clean My Room", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, "Apartment Rent", new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
