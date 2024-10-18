using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class rolename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "f7109bc5-b0f7-41c6-a580-1f49f4856532", null, null, "AQAAAAIAAYagAAAAEEefnPKwxCePZDI1dcf2XHWXHtljD64jUb5YNo3TjtaCXb31hAy1vaoQOyMANTDltg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "8b55dfc6-8a28-49b2-8a7f-5ea593e2924d", null, null, "AQAAAAIAAYagAAAAEHl8KtLWZ7/SOxRkbhNl6A0OgqaH6n067Ay8aSe6FMXNkhFyss25u+Ob7G7u+lRnEg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "e1e91cbf-d223-4534-a555-18ddb7ce8bd6", null, null, "AQAAAAIAAYagAAAAEIRSQ8dD+Wc+Un64oyR1e6uMpsN4cR9W7DJdxEzqwSpEq465azjp9bt7kZPwXlKMyw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "d54ccc8e-fbdd-488a-afd9-c8661d0f7420", null, null, "AQAAAAIAAYagAAAAEHkkfdUjpwT9rFNk0u/dEK6iZ+xwv8Q7Q9jHv7tsDtHhUtzHdMuJocjnTMgfR7M78A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "ab89c9d6-e1d5-4994-861c-2f9a4d76f59a", null, null, "AQAAAAIAAYagAAAAENklzf7Qu3QALusL8SCMvuHlnxI4QqZNsJl2XIxyzxGkS44I9zp1de1XcvGrM+e1sQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "a8380c17-a6c1-4f78-ae7d-bc2aebd8dac0", null, null, "AQAAAAIAAYagAAAAEKoBPjJddksObMcuMB+R1HDMOu2c8StBb5r/r82pST6IjGOZ2Gk6l+9k6rZo+Ig2OA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d25339b-5f8e-485f-a82d-210b5712b0af", "AQAAAAIAAYagAAAAENguv5E0DQxINOakx0nDmeHU4DRAQmaCQWV2VDv7qkeTD8WFHgJUfts2+boR7pRiYA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "458837d5-548e-4734-aa59-4493c1f39571", "AQAAAAIAAYagAAAAEDvN8fk5lzeCx5S0QqAvigIuAsVv90Ss9qrJshS/T1fbhakYwznk/sP9zpQPBeOgig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af6f02af-afcd-4c62-ad88-f10b4c0cb41d", "AQAAAAIAAYagAAAAEBj7wZt5xVSK/fMmUJ1O+hgWk3ap5yTME0KPVzjIa3h2ZuHa2y20tF9poGH6zNGqbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a44198c-d9f5-4536-883c-d5b7dddb393f", "AQAAAAIAAYagAAAAEOrjkyN1vMyRfJu9wG3Z1FVh7LggbOjXk5gp1FNM91qKVK2+wzD87mgJvggl1DDKDQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "85346c72-6b0b-43e4-b4b6-02bc2d37d822", "AQAAAAIAAYagAAAAECgIkPJLTxcjVhIjOE6U6nXQ/FGr1wgNrvcEuXwFmjeYB4Jpa5Jlywhb1w4Z2kNJNA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d4e8007-bf32-45d7-af39-8388be82ce1c", "AQAAAAIAAYagAAAAEHnEGivWBWRAdj/jAYK2m+yeGmZl6QHnXO0LsbqB+KuhVcFZF0+6xrNrsvHM8EVmOg==" });
        }
    }
}
