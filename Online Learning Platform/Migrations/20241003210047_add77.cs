using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class add77 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a5837887-6612-4c0d-a051-48c71c2653a5", "AQAAAAIAAYagAAAAEHEiWFr6Ohir6sqKYLp1qVlhlkLq1eztCabmFiSR4BW8PYvSYES/q4PeHOeVKdSVow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "527440d7-02c8-42fb-9586-e337d71c4fc8", "AQAAAAIAAYagAAAAEB8QZDRT8U9/iXX3hrA3R/xdY/nn6PSkkoMFrcphAryhBrm+RnCH+B2kZ6a9y14LTA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "772aa9dc-e182-44dc-9f61-3149131013a6", "AQAAAAIAAYagAAAAEAJG6rHOSo3J/xwVILvfoRouPXLSZxa5AXAitatk3zyjsGk4sxBbDjmA4II46wJlSg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e4e165a-279f-4a77-80e4-2ccf8f300a8e", "AQAAAAIAAYagAAAAECqUE7nhUYU2WpGGYUGd7Rhl6NBLnMJxvrIyhogBdeFmC2tYqAfa/WXjhtoq3CKR7A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8712189-873d-428b-861d-7cdb2d12ef63", "AQAAAAIAAYagAAAAEIkTDnJrmbLtle51Pn8LEA4oAAOUYcVnJSmYWEq95bDBog3F43+1EIQCQn/6uVedBw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "be588543-0135-44d2-9976-da88c72a85ec", "AQAAAAIAAYagAAAAEJmn0f1ofrev1l591xTiFJq/n9HISXyfNXJmQ93C1rknErUY1zexfwJCKdyHWygG3Q==" });
        }
    }
}
