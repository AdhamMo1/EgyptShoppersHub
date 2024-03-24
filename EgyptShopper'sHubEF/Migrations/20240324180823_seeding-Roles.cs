using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EgyptShopper_sHubEF.Migrations
{
    /// <inheritdoc />
    public partial class seedingRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b5c9a94-0bce-4134-b15f-41c984df0c5e", "86180e80-9e7a-41db-ae12-f0caad16e2da", "Admin", "ADMIN" },
                    { "14b7639a-f925-4395-af61-a9eabf8a2c3f", "58197a55-d863-451b-82d7-ea8805812602", "Client", "CLIENT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b5c9a94-0bce-4134-b15f-41c984df0c5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14b7639a-f925-4395-af61-a9eabf8a2c3f");
        }
    }
}
