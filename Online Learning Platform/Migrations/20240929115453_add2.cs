using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class add2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "98d0063e-63b4-469d-8a21-29aaafd511e7", "AQAAAAIAAYagAAAAEKp1JFOwlGnBIjE8HO80uh+BRvsxI632xZcOZDUy7YBpSLqXdz+zM9ivmhUTepuLIg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e5dd97f-a968-4c53-bd6b-ec5183d9a63e", "AQAAAAIAAYagAAAAEANk5ZaHtIucbSr1hieWNg6Yy1hgodpgJsojYdb4JL0CM6825vTYUhV2RUVi9DS1ig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f792b45-a365-43e3-9e2b-75ff49543941", "AQAAAAIAAYagAAAAEJwH8OmUhjhF93U0n1Pqzmo6yA3cm21YX6eHo3e8SjsbKMbcfL7XU2CZhr6BhL17Lw==" });
        }
    }
}
