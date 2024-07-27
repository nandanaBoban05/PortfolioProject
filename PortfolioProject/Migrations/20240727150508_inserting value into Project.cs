using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioProject.Migrations
{
    /// <inheritdoc />
    public partial class insertingvalueintoProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "EndDate", "Name", "StartDate", "Url" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 6, 30), "Eliassen Group", new DateOnly(2024, 2, 5), "http://project1.com" },
                    { 2, new DateOnly(2024, 8, 15), "Project 2", new DateOnly(2024, 3, 1), "http://project2.com" },
                    { 3, new DateOnly(2024, 9, 20), "Project 3", new DateOnly(2024, 4, 10), "http://project3.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3);
        }
    }
}
