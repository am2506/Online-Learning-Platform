using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class image : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7109bc5-b0f7-41c6-a580-1f49f4856532", "AQAAAAIAAYagAAAAEEefnPKwxCePZDI1dcf2XHWXHtljD64jUb5YNo3TjtaCXb31hAy1vaoQOyMANTDltg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b55dfc6-8a28-49b2-8a7f-5ea593e2924d", "AQAAAAIAAYagAAAAEHl8KtLWZ7/SOxRkbhNl6A0OgqaH6n067Ay8aSe6FMXNkhFyss25u+Ob7G7u+lRnEg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e1e91cbf-d223-4534-a555-18ddb7ce8bd6", "AQAAAAIAAYagAAAAEIRSQ8dD+Wc+Un64oyR1e6uMpsN4cR9W7DJdxEzqwSpEq465azjp9bt7kZPwXlKMyw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d54ccc8e-fbdd-488a-afd9-c8661d0f7420", "AQAAAAIAAYagAAAAEHkkfdUjpwT9rFNk0u/dEK6iZ+xwv8Q7Q9jHv7tsDtHhUtzHdMuJocjnTMgfR7M78A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab89c9d6-e1d5-4994-861c-2f9a4d76f59a", "AQAAAAIAAYagAAAAENklzf7Qu3QALusL8SCMvuHlnxI4QqZNsJl2XIxyzxGkS44I9zp1de1XcvGrM+e1sQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a8380c17-a6c1-4f78-ae7d-bc2aebd8dac0", "AQAAAAIAAYagAAAAEKoBPjJddksObMcuMB+R1HDMOu2c8StBb5r/r82pST6IjGOZ2Gk6l+9k6rZo+Ig2OA==" });
        }
    }
}
