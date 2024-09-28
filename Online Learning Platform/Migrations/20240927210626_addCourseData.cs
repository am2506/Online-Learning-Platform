using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class addCourseData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "cd180811-92d0-4688-84fa-1d1ab29bce46", "Instructor", "Heba@gmail.com", false, "Heba", "Mohammed", false, null, null, null, null, null, false, null, false, null },
                    { 2, 0, "ba2bf242-dc95-48c5-94bc-f1994ffa4134", "Instructor", "Shahd@gmail.com", false, "Shahd", "Sofy", false, null, null, null, null, null, false, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Programming" },
                    { 2, "Mathematics" },
                    { 3, "Science" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "Duration", "ImageUrl", "InstructorId", "Title", "TotalLecture" },
                values: new object[,]
                {
                    { 1, 1, "Learn the basics of C# programming.", 10.5, "/images/c#.png", 1, "C# Programming", 20 },
                    { 2, 2, "An advanced course on calculus and linear algebra.", 8.0, "/images/math.png", 2, "Advanced Mathematics", 15 },
                    { 3, 1, "Learn the basics of Python programming.", 10.5, "/images/python.png", 1, "Python Programming", 20 }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "CourseId", "StudentId", "EnrollmentDate", "Id", "Prograss" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0 },
                    { 2, 1, new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 50 }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "CourseId", "Id", "VideoUrl" },
                values: new object[,]
                {
                    { 1, 1, "/videos/video.mp4" },
                    { 1, 2, "/videos/video.mp4" },
                    { 2, 3, "/videos/video.mp4" },
                    { 2, 4, "/videos/video.mp4" },
                    { 3, 5, "/videos/video.mp4" },
                    { 3, 6, "/videos/video.mp4" },
                    { 3, 7, "/videos/video.mp4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumns: new[] { "CourseId", "Id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumns: new[] { "CourseId", "Id" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumns: new[] { "CourseId", "Id" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumns: new[] { "CourseId", "Id" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumns: new[] { "CourseId", "Id" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumns: new[] { "CourseId", "Id" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumns: new[] { "CourseId", "Id" },
                keyValues: new object[] { 3, 7 });

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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
