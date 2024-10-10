using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class add3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d58d4414-1945-4828-9554-9c379930e06d", "AQAAAAIAAYagAAAAEP1sJ69A+NmjczmskRSvC3kLZM+Ia2hFZ41F7sPXCQVtHPnpm7rD7wx/XZvxsBdFkg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fce26061-8a6c-4753-a7c1-69c4f7b414b2", "AQAAAAIAAYagAAAAENXBgv0dG0e7fOKhkz+VHEiZ0Jqh8l+zOBUfL4S7n/30A7k7xRyNk6iK7rtbL5Cm4w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5074f668-b8d2-4e65-9895-4b4fe20dccde", "AQAAAAIAAYagAAAAEP4+toMZWY4rac/0NP489FPpz1dKu6rdFwB9jKfvvr+uiTr5kk89VAmLhlNzf+LC/A==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a76b5234-3623-4660-9baa-65c0906aa7f2", "AQAAAAIAAYagAAAAEJ6CG1deft3kNq4Uw/ejA68TVKI+h5wXGUjHQgQi5eT1T9YnzzUrGXZ4B/st27yd2g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "20e54ea8-f3d0-4099-b631-fdfa752c2a9c", "AQAAAAIAAYagAAAAEFFfLAC5zWfEBSDNu8raaK2Y/5EM7PaQPM6assbXUTvdVT5kpUjaaibLYbJSWyzQwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6c320da2-43c5-4ce9-8ae0-9663d2e44a8c", "AQAAAAIAAYagAAAAEIIEj8woIJ9B3lkKYvjZT+k0g+4mqznoMWk7HpUb2OpZlp4zTUOmYgNEzk2XMKRNvA==" });
        }
    }
}
