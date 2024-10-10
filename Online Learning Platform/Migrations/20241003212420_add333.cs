using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class add333 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "522b6157-32b6-4708-903e-0c8a86885694", "AQAAAAIAAYagAAAAEA/a2pW6M6Gtg5p2I6/8sXt0oqXjRrb+n9Z9KiGfTcJFWW080BavoWw/umajSTAjww==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "71719730-4349-4445-990b-1bd2a2443e40", "AQAAAAIAAYagAAAAEEsYzaQXpJDYyfMnVvaP3WiH1Ws+8P0wmB4O1dDD4/x001HBRiNDGmiPr8GlT66cIA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b779b685-7788-41a0-8059-7404c7014d36", "AQAAAAIAAYagAAAAEKOB+1aAdbb+7KEPlLlBXNUS/mFGZj83hThM4jSItl1wXEeCMXgdFChqVTblyDWBqQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3fc0bd6c-3169-430e-ae73-afbfd9f7c11a", "AQAAAAIAAYagAAAAEPiiX0zrw98ZeOV3sw+yw3lkzdYMyGjGoyvZgDt/UvjkISXCqOYmuLNXE4/MvXWFHg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f4722acf-f069-4bbb-8e6f-fe438ba95b1a", "AQAAAAIAAYagAAAAEM7a7mgmsGXldF7DqafqcTwHW8gzN2GBoBv0zQafE8oSpKY0+GShRS/hUQY/QNs0ow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23702ec7-9eae-41d9-a712-835a44ebf3c8", "AQAAAAIAAYagAAAAEGCfyrFIz6vAG9XxKJ8CBbxXXd+IGHc36H4rUBeQfltzQmtuy+Upwlrvl9Ye+3BtFg==" });
        }
    }
}
