using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Admin", "ADMIN" },
                    { 2, null, "Instructor", "INSTRUCTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "98d0063e-63b4-469d-8a21-29aaafd511e7", "UserBase", "instructor1@example.com", true, false, null, "INSTRUCTOR1@EXAMPLE.COM", "INSTRUCTOR1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKp1JFOwlGnBIjE8HO80uh+BRvsxI632xZcOZDUy7YBpSLqXdz+zM9ivmhUTepuLIg==", null, false, null, false, "instructor1@example.com" },
                    { 2, 0, "1e5dd97f-a968-4c53-bd6b-ec5183d9a63e", "UserBase", "instructor2@example.com", true, false, null, "INSTRUCTOR2@EXAMPLE.COM", "INSTRUCTOR2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEANk5ZaHtIucbSr1hieWNg6Yy1hgodpgJsojYdb4JL0CM6825vTYUhV2RUVi9DS1ig==", null, false, null, false, "instructor2@example.com" },
                    { 3, 0, "4f792b45-a365-43e3-9e2b-75ff49543941", "UserBase", "instructor3@example.com", true, false, null, "INSTRUCTOR3@EXAMPLE.COM", "INSTRUCTOR3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJwH8OmUhjhF93U0n1Pqzmo6yA3cm21YX6eHo3e8SjsbKMbcfL7XU2CZhr6BhL17Lw==", null, false, null, false, "instructor3@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Development" },
                    { 2, "Design" }
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

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "Duration", "ImageUrl", "InstructorId", "Title", "TotalLecture" },
                values: new object[,]
                {
                    { 1, 1, "Learn ASP.NET Core", 10.0, null, 1, "ASP.NET Core", 20 },
                    { 2, 1, "Learn EF Core", 8.0, null, 2, "Entity Framework", 16 },
                    { 3, 1, "Learn JavaScript", 6.0, null, 3, "JavaScript Basics", 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
