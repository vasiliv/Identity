using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Identity.Migrations
{
    /// <inheritdoc />
    public partial class RolesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d9f6d40-c123-4d19-b110-1f09295bd22b", null, "admin", "admin" },
                    { "c886b4d7-3f5b-4d1a-ad0a-05405a8a3c13", null, "seller", "seller" },
                    { "d0cb8945-8f75-4bf2-a134-7f1492011832", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d9f6d40-c123-4d19-b110-1f09295bd22b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c886b4d7-3f5b-4d1a-ad0a-05405a8a3c13");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0cb8945-8f75-4bf2-a134-7f1492011832");
        }
    }
}
