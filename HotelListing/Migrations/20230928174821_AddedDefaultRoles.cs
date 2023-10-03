using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ad23e45-a231-49c5-959f-26b5ca3f0be7", "bd34f833-62bd-4220-9ebd-320db93b91ad", "User", "User" },
                    { "24aacb84-05f6-49c8-9d5c-792a6ba1f27b", "fdf29c20-e2e9-4116-beb2-1c206d206550", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ad23e45-a231-49c5-959f-26b5ca3f0be7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24aacb84-05f6-49c8-9d5c-792a6ba1f27b");
        }
    }
}
