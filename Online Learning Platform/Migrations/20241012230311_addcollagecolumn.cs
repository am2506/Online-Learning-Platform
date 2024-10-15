using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class addcollagecolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "DevData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Full Stack .Net Developer",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "DevData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Fayoum ,Egypt",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "College",
                table: "DevData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "724ac96f-5054-43e0-b48c-5853e05bbf9a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "441c5720-9e91-41c0-aa81-6f0aa8fce308");

            migrationBuilder.UpdateData(
                table: "DevData",
                keyColumn: "Id",
                keyValue: 1,
                column: "College",
                value: "Faculty of Computer and Information");

            migrationBuilder.UpdateData(
                table: "DevData",
                keyColumn: "Id",
                keyValue: 2,
                column: "College",
                value: "Faculty of Engineering");

            migrationBuilder.UpdateData(
                table: "DevData",
                keyColumn: "Id",
                keyValue: 3,
                column: "College",
                value: "Faculty of Computer and Information");

            migrationBuilder.UpdateData(
                table: "DevData",
                keyColumn: "Id",
                keyValue: 4,
                column: "College",
                value: "Faculty of Computer and Information");

            migrationBuilder.UpdateData(
                table: "DevData",
                keyColumn: "Id",
                keyValue: 5,
                column: "College",
                value: "Faculty of Computer and Information");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "College",
                table: "DevData");

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "DevData",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Full Stack .Net Developer");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "DevData",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Fayoum ,Egypt");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e143fb04-38da-45c3-b108-0bdd70acf715");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f0812a9a-1a4f-4517-b48e-be3f731ee689");
        }
    }
}
