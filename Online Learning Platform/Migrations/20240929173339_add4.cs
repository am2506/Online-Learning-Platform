using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class add4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.AddColumn<string>(
                name: "RoleName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 3, null, "Student", "STUDENT" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RoleName", "UserName" },
                values: new object[] { "a5837887-6612-4c0d-a051-48c71c2653a5", false, null, null, "AQAAAAIAAYagAAAAEHEiWFr6Ohir6sqKYLp1qVlhlkLq1eztCabmFiSR4BW8PYvSYES/q4PeHOeVKdSVow==", "Instructor", "instructor1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RoleName", "UserName" },
                values: new object[] { "527440d7-02c8-42fb-9586-e337d71c4fc8", false, null, null, "AQAAAAIAAYagAAAAEB8QZDRT8U9/iXX3hrA3R/xdY/nn6PSkkoMFrcphAryhBrm+RnCH+B2kZ6a9y14LTA==", "Instructor", "instructor2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RoleName", "UserName" },
                values: new object[] { "772aa9dc-e182-44dc-9f61-3149131013a6", false, null, null, "AQAAAAIAAYagAAAAEAJG6rHOSo3J/xwVILvfoRouPXLSZxa5AXAitatk3zyjsGk4sxBbDjmA4II46wJlSg==", "Instructor", "instructor3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RoleName", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 4, 0, "5e4e165a-279f-4a77-80e4-2ccf8f300a8e", "UserBase", "Student1@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAECqUE7nhUYU2WpGGYUGd7Rhl6NBLnMJxvrIyhogBdeFmC2tYqAfa/WXjhtoq3CKR7A==", null, false, "Student", null, false, "Student1" },
                    { 5, 0, "b8712189-873d-428b-861d-7cdb2d12ef63", "UserBase", "Student2@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEIkTDnJrmbLtle51Pn8LEA4oAAOUYcVnJSmYWEq95bDBog3F43+1EIQCQn/6uVedBw==", null, false, "Student", null, false, "Student2" },
                    { 6, 0, "be588543-0135-44d2-9976-da88c72a85ec", "UserBase", "Student3@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEJmn0f1ofrev1l591xTiFJq/n9HISXyfNXJmQ93C1rknErUY1zexfwJCKdyHWygG3Q==", null, false, "Student", null, false, "Student3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "RoleName",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRole_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "d58d4414-1945-4828-9554-9c379930e06d", true, "INSTRUCTOR1@EXAMPLE.COM", "INSTRUCTOR1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP1sJ69A+NmjczmskRSvC3kLZM+Ia2hFZ41F7sPXCQVtHPnpm7rD7wx/XZvxsBdFkg==", "instructor1@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "fce26061-8a6c-4753-a7c1-69c4f7b414b2", true, "INSTRUCTOR2@EXAMPLE.COM", "INSTRUCTOR2@EXAMPLE.COM", "AQAAAAIAAYagAAAAENXBgv0dG0e7fOKhkz+VHEiZ0Jqh8l+zOBUfL4S7n/30A7k7xRyNk6iK7rtbL5Cm4w==", "instructor2@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "5074f668-b8d2-4e65-9895-4b4fe20dccde", true, "INSTRUCTOR3@EXAMPLE.COM", "INSTRUCTOR3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP4+toMZWY4rac/0NP489FPpz1dKu6rdFwB9jKfvvr+uiTr5kk89VAmLhlNzf+LC/A==", "instructor3@example.com" });
        }
    }
}
