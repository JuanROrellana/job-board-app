using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobBoardApp.Migrations
{
    public partial class SeedJobBoard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("8d27d788-b745-4232-98c8-4e17d10a2695"));

            migrationBuilder.DeleteData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("ec911ec6-3c20-40f8-9397-5acb4a758d71"));

            migrationBuilder.DeleteData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("fad66607-3085-4162-959c-0812531da308"));

            migrationBuilder.InsertData(
                table: "BoardGames",
                columns: new[] { "Id", "CreatedAt", "Description", "ExpiresAt", "Job", "JobTitle" },
                values: new object[] { new Guid("ccbbdb91-713b-4172-b45a-2a07abaf3339"), new DateTime(2020, 9, 20, 22, 3, 22, 803, DateTimeKind.Local).AddTicks(7738), "Asp C# programming and JavaScript", new DateTime(2020, 9, 27, 22, 3, 22, 807, DateTimeKind.Local).AddTicks(8090), "ASP Programmer", "System Engineer" });

            migrationBuilder.InsertData(
                table: "BoardGames",
                columns: new[] { "Id", "CreatedAt", "Description", "ExpiresAt", "Job", "JobTitle" },
                values: new object[] { new Guid("2a7d6f50-9c6d-4dbf-a48e-193dab563c77"), new DateTime(2020, 9, 20, 22, 3, 22, 807, DateTimeKind.Local).AddTicks(8459), "Laravel programming expert", new DateTime(2020, 9, 27, 22, 3, 22, 807, DateTimeKind.Local).AddTicks(8468), "PHP Programmer", "System Engineer" });

            migrationBuilder.InsertData(
                table: "BoardGames",
                columns: new[] { "Id", "CreatedAt", "Description", "ExpiresAt", "Job", "JobTitle" },
                values: new object[] { new Guid("80c469e8-e547-4391-8e78-1cb6634b931c"), new DateTime(2020, 9, 20, 22, 3, 22, 807, DateTimeKind.Local).AddTicks(8486), "Django Programming", new DateTime(2020, 9, 27, 22, 3, 22, 807, DateTimeKind.Local).AddTicks(8488), "Python Programmer", "System Engineer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("2a7d6f50-9c6d-4dbf-a48e-193dab563c77"));

            migrationBuilder.DeleteData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("80c469e8-e547-4391-8e78-1cb6634b931c"));

            migrationBuilder.DeleteData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("ccbbdb91-713b-4172-b45a-2a07abaf3339"));

            migrationBuilder.InsertData(
                table: "BoardGames",
                columns: new[] { "Id", "CreatedAt", "Description", "ExpiresAt", "Job", "JobTitle" },
                values: new object[] { new Guid("ec911ec6-3c20-40f8-9397-5acb4a758d71"), new DateTime(2020, 9, 20, 21, 57, 37, 187, DateTimeKind.Local).AddTicks(9418), "Asp C# programming and JavaScript", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP Programmer", "System Engineer" });

            migrationBuilder.InsertData(
                table: "BoardGames",
                columns: new[] { "Id", "CreatedAt", "Description", "ExpiresAt", "Job", "JobTitle" },
                values: new object[] { new Guid("8d27d788-b745-4232-98c8-4e17d10a2695"), new DateTime(2020, 9, 20, 21, 57, 37, 191, DateTimeKind.Local).AddTicks(4751), "Laravel programming expert", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PHP Programmer", "System Engineer" });

            migrationBuilder.InsertData(
                table: "BoardGames",
                columns: new[] { "Id", "CreatedAt", "Description", "ExpiresAt", "Job", "JobTitle" },
                values: new object[] { new Guid("fad66607-3085-4162-959c-0812531da308"), new DateTime(2020, 9, 20, 21, 57, 37, 191, DateTimeKind.Local).AddTicks(4858), "Django Programming", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Python Programmer", "System Engineer" });
        }
    }
}
