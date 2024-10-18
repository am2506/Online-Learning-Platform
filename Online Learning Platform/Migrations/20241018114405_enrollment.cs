using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class enrollment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a302e6f-e1f1-4c12-9d76-16fc641b69c6", "AQAAAAIAAYagAAAAEHBsaPbe2WxEbHZW2MIVu2puwTFrmu4JqJQF2zdU5dNeiW1qNJu9pXvDdTKeP4FGXQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c087cccd-d783-4455-9724-fb22be3cc8a0", "AQAAAAIAAYagAAAAEMmaGIvOm8WvkGdTpzPPLw8tcXdre/b3Jb0reublMhtWd2fx+qmkZ9geU2pKjst1Lg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e466c3e6-21b0-4c31-a985-dc4f18308147", "AQAAAAIAAYagAAAAEIgGq1EW3nSgrrfH5E4UMZmLVzJOOuI4mxS90M7FXlwOh6Cag7A+lNm0gzLhLmf6sQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7235288-5f1d-4c36-a85d-dec93eb2b158", "AQAAAAIAAYagAAAAEKxHIUdcyvankAnIagm3Az4vQ31KpGKndLjK5jR7ICV3u2En36wAifp0q68E7BZk0Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "363b4dd2-ef5c-44c7-9bc9-fdb624540cc9", "AQAAAAIAAYagAAAAEOCbZqvojTNfk+u/92bleekkn0viItPSnYFKd0/Ni3LL/+AkJVrrH0nB5APYG+ZqMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "39f826e1-860b-484a-9a44-60eb519efabc", "AQAAAAIAAYagAAAAEHZ1mEVadl5wWdaXScQKGt624ZaVPkb2dgv0CLiwSAGBANbVIvxIqNXE5GRSN1jwOw==" });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "CourseId", "StudentId", "EnrollmentDate", "Id", "Prograss" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2024, 10, 8, 14, 44, 4, 606, DateTimeKind.Local).AddTicks(2180), 1, 50 },
                    { 1, 5, new DateTime(2024, 10, 13, 14, 44, 4, 606, DateTimeKind.Local).AddTicks(2462), 4, 80 },
                    { 2, 5, new DateTime(2024, 10, 10, 14, 44, 4, 606, DateTimeKind.Local).AddTicks(2320), 2, 70 },
                    { 2, 6, new DateTime(2024, 10, 15, 14, 44, 4, 606, DateTimeKind.Local).AddTicks(2467), 5, 90 },
                    { 3, 6, new DateTime(2024, 10, 12, 14, 44, 4, 606, DateTimeKind.Local).AddTicks(2325), 3, 30 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88406e47-3400-439c-a0bb-2e4867bfef20", "AQAAAAIAAYagAAAAEGwW/M3oS7jEjqaGW8ECe82ZukTQwQ7/zzYEOu8rQoWBeYizzsRKDbBvUA0R7LQdRw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d7f5ab5-c036-45ae-bd4e-48d12169f538", "AQAAAAIAAYagAAAAEMUlkkl6Sj6q89Ueo8U/Bu6qB5Li/i+bMJsCu1ewgNZQdL8CtKElJ9Xw1brkC4jUcA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f6fb2f47-317b-4fcb-8646-a85b45788f9d", "AQAAAAIAAYagAAAAENsgEmxBLdbYA5Lo2opnXaJztEm2lvWIQJ1Y9HF1UsHRVEwpG9N8z7IdsWxR8VLgEA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "11bffde5-de1a-47b3-9ed8-6e8dac594a09", "AQAAAAIAAYagAAAAEH3q/rA4BZ+ydr0rXyJPDT1nQcQ3Gdf6WHeWyxI/ccG0Lhugsdng//+obFrLgaJNmA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29878d53-4b95-4a74-aa46-fb47b4cd4fce", "AQAAAAIAAYagAAAAEGA7BDO5PHO8Gd959+0ttZGhgjHkvxKDpIp7n9ApFh4TM7hoOgXM+gvacodsUbTmNA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "958a0710-59d4-4de9-948f-e3e165d46855", "AQAAAAIAAYagAAAAEI/ImwyZC3YSnf92BZ7U1bm3tmqCoy8Odd4y1G2A9Xv6Y4ifGvLBnQCm10q4dCWu1w==" });
        }
    }
}
