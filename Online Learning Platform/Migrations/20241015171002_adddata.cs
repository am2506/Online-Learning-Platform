using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class adddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "5d08c359-45ba-4d81-9dd0-219131ba6ba2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f1971258-e8d5-4906-b824-96b32dcc0e5d");

            migrationBuilder.UpdateData(
                table: "DevData",
                keyColumn: "Id",
                keyValue: 1,
                column: "LinkedinUrl",
                value: "https://www.linkedin.com/in/a7medmansour/");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "35ee0de9-545d-47a3-b02a-2fad06a4a7bd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2ad9413c-7c13-4739-87d8-6e9c5bca0540");

            migrationBuilder.UpdateData(
                table: "DevData",
                keyColumn: "Id",
                keyValue: 1,
                column: "LinkedinUrl",
                value: "#");
        }
    }
}
