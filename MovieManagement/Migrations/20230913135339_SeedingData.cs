using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Khanh" },
                    { 2, "James Cameron" },
                    { 3, "Joss Whedon" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Country", "DirectorId", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Viet Nam", 1, "C# Fuck My Life Every Days", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "US", 2, "Avatar", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "US", 2, "Avatar 2: The ways of water", new DateTime(2022, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "US", 3, "Justice League", new DateTime(2023, 9, 13, 20, 53, 39, 800, DateTimeKind.Local).AddTicks(7944) },
                    { 5, "US", 3, "The flash", new DateTime(2023, 9, 13, 20, 53, 39, 800, DateTimeKind.Local).AddTicks(7954) }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "MovieId" },
                values: new object[,]
                {
                    { 1, "Haha", 1 },
                    { 2, "Haha", 2 },
                    { 3, "Haha", 3 },
                    { 4, "Haha", 4 },
                    { 5, "Haha", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
