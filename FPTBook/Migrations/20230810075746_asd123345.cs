using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook.Migrations
{
    public partial class asd123345 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Carts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101",
                column: "ConcurrencyStamp",
                value: "7ddabd67-0e80-48ed-9d92-33244cb711b4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102",
                column: "ConcurrencyStamp",
                value: "19036af9-38a4-413e-9af8-ecda07645a65");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103",
                column: "ConcurrencyStamp",
                value: "0910f9ca-bbcf-4405-9666-a5652dd8dd93");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8333e06f-bba9-4542-9539-ed92b8f770b4", "AQAAAAEAACcQAAAAEEy6bC3DdmoKrY5kHCJOP00c8G9UcAsA69PPfvpGQfjjGsfuOP/4lrqQf9i7gJ63Ww==", "b631b618-8df4-4680-9729-1be2795eaebd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b65899b9-e577-4d9e-b7b5-4ebebea0a222", "AQAAAAEAACcQAAAAED729/jJmUoqV0/K6fS6GotD41gmu5+HUJE1MJZzDlsDs6mL05zW/GYzmTUgMSlvMQ==", "e84e0efc-ca4d-4b29-ac79-7bc7f0be272a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be2c8be0-5a15-4165-8d10-f03b0d06cb14", "AQAAAAEAACcQAAAAEGF7keGpRsOfnGEYUuiu6mBla/Ok2T9BJn/PurLSst4RV6Rd08sW3ZtBakbsjIcEeQ==", "a557437c-e2c2-4faf-8ec0-76f1c9388e91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f56a7fc0-0c23-40ec-b60b-337426b6f768", "AQAAAAEAACcQAAAAEC5bcKEL5zNSj+o+/ofAHSD3pcZhXwDziBq6fC3J3itB+xa7sa0U5cpogfTNqC01ZA==", "b3a05e4e-e475-405f-b8ef-55ccaa6ee3c1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Carts");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101",
                column: "ConcurrencyStamp",
                value: "c90cd27c-5cc8-4c74-8aa4-5607fe4e0f2e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102",
                column: "ConcurrencyStamp",
                value: "427bf969-7077-4bf9-b5a4-5fc9ffc77cda");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103",
                column: "ConcurrencyStamp",
                value: "1505412a-a600-46b9-94dc-152ab8132623");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef638c04-4939-4c50-883c-d00b69ea25ec", "AQAAAAEAACcQAAAAEG6g4ED9G2VarXYbZpGKeLRgGnQ+AIYrQxtfo3XovZTrwk1j6QlCU8lhPAh6y6plug==", "4cfad84c-9f58-411c-a3f3-9bda1e7461bf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4922e4d7-109f-440f-90a4-8063b29959b6", "AQAAAAEAACcQAAAAEIeZwQRj8++o68IsFKWDt6KgmnXNucY0CkffeRcPLAElI6kmgBQe/EzKlw4e/yDrbg==", "f3f112eb-6299-439c-993f-cec18d3910dd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c48d065a-4d9b-4fe7-b973-8018b87db78d", "AQAAAAEAACcQAAAAEJocHBDHMAgf0V/K8q0J4fitEJesjuWkCaHWN1N6vsSzF1VwzuSU0xeWdUKhRKQXSA==", "653e59c1-a975-4bc1-aaf0-e2ca0c669f38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9175755a-3266-4f24-9597-4b6066c3c03f", "AQAAAAEAACcQAAAAEC49Ni50Pkg2btU6iIa5KcIwYqFB9zyXpeXo+2i/o5Bu0mwG2YVq4D88KKeAp/bJRA==", "32ba97b4-20e0-4a44-a732-04e21f691766" });
        }
    }
}
