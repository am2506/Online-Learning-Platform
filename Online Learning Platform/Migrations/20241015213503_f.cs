using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class f : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "97418907-dda7-4af5-87f0-270d4bcfb85c", "AQAAAAIAAYagAAAAEIkgyXXrdeJbvSHd6m0GFLwMjKsc5l5madPhYDDCEmYzj0iifPORwGFwNSkIhOSZAQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "26f11f94-6838-4405-b9ec-712cb7743586", "AQAAAAIAAYagAAAAEDbH84/t+6JtEVCxxRvG7dX08f/yAuJZ5U1F0XLys67xGl0VeF9BUKwzaDmDBrPeLg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f15639eb-654e-46f6-90f4-4a46d0126e5f", "AQAAAAIAAYagAAAAEHJVs7SppAi8ohDIrnAruX4Elf6DIwNibXA5M/IgmNEOzvt+FxnKVp/JJoh0QNux+g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "332425b1-9027-434a-8a58-f66f2e8e39d7", "AQAAAAIAAYagAAAAEH040Z/SQLc4W78/F3ciedTZAVa2TUzf5R14NIYdrefvvTfohA69MtBXfec00k/sCA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "10db481f-de03-4198-ac09-58a48294166d", "AQAAAAIAAYagAAAAEJVEx5cSPXuoeYZeiLm7Mq1Ckrul2N4Hr68YRDinh1ExAk3OiSJkpSc60hH6ZoQ/dw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e97a2c6b-0914-4d4a-a2e5-91c86490b2e9", "AQAAAAIAAYagAAAAEJIUa1XUTc5BOSLI8NOFKB8tmVWWrTMuog4MaE6HEXQsCpu6cxZg+X17mmvjKJBVwg==" });
        }
    }
}
