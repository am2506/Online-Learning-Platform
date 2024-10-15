using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class DevTableAndData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DevData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevData", x => x.Id);
                });

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

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/cSharp.png");

            migrationBuilder.InsertData(
                table: "DevData",
                columns: new[] { "Id", "Address", "ImageUrl", "Job", "LinkedinUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Fayoum ,Egypt", "/images/avatar7.png", "Full Stack .Net Developer", "#", "Ahmed Mansour" },
                    { 2, "Fayoum ,Egypt", "/images/avatar7.png", "Full Stack .Net Developer", "#", "Mohamed Khaled" },
                    { 3, "Fayoum ,Egypt", "/images/images (1).jpeg", "Full Stack .Net Developer", "https://www.linkedin.com/in/heba-muhammad-64768924a/", "Heba Mohamed" },
                    { 4, "Fayoum ,Egypt", "/images/images (1).jpeg", "Full Stack .Net Developer", "https://www.linkedin.com/in/nisreen-nasr-295079222/", "Nisreen Nasr" },
                    { 5, "Fayoum ,Egypt", "/images/images (1).jpeg", "Full Stack .Net Developer", "https://www.linkedin.com/in/shahd-sofy-6573742a7/", "Shahd Sofy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DevData");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "cd180811-92d0-4688-84fa-1d1ab29bce46");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ba2bf242-dc95-48c5-94bc-f1994ffa4134");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/c#.png");
        }
    }
}
