using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook.Migrations
{
    public partial class asd1233454 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101",
                column: "ConcurrencyStamp",
                value: "a60470f7-ff1a-44fe-b241-9fcf46c824a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102",
                column: "ConcurrencyStamp",
                value: "ebc25e83-3d66-4db0-8c2a-516bcef1fef6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103",
                column: "ConcurrencyStamp",
                value: "2c3c6b48-597c-416a-933d-e0fe52d45917");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c0b2c25-0592-4d89-abea-72f173d115cf", "Nguyen Van Admin", "AQAAAAEAACcQAAAAEEuSEuhr2H7Yu084j73f1XuHF6U3YJ2yiANK4SG2qyIBjaR8/hIIzh69/m3RRVpYZw==", "2ee8bf94-c1c9-4ecb-8eba-227b408a394f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5221c015-46f5-4471-a595-f5d178500dd7", "Nguyen Van store", "AQAAAAEAACcQAAAAECpfyVNZ3LxMyZztIWtF5F8r1Zn0dDkw7JcjFYsrMhvJt6caKdddB/p10Ap4kJYikw==", "29e4462a-6ba8-4bd5-bcc6-0a7c9625a059" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dc9fe07-8008-44de-b4dd-691f38334419", "Nguyen Van store", "AQAAAAEAACcQAAAAEGpZ1ir2tIZCRZD8D3gJyLlqtIS99PUxM17+cNml9H5wflX+rkS5h0hb6+r1otVQ3g==", "c507917a-a7bc-4a3c-bdc8-63671e9acae9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c056b108-52d5-4a5d-a128-04690c84b836", "Nguyen Van customer", "AQAAAAEAACcQAAAAEOzOnRguSUoeZiM+BVMLBQ/xDWEQbajax+gi33A86tO5+nxcT+jz0iWndRX1zCcg3w==", "9ff9c952-25bc-4016-8f1e-92ae45308b24" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8333e06f-bba9-4542-9539-ed92b8f770b4", null, "AQAAAAEAACcQAAAAEEy6bC3DdmoKrY5kHCJOP00c8G9UcAsA69PPfvpGQfjjGsfuOP/4lrqQf9i7gJ63Ww==", "b631b618-8df4-4680-9729-1be2795eaebd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b65899b9-e577-4d9e-b7b5-4ebebea0a222", null, "AQAAAAEAACcQAAAAED729/jJmUoqV0/K6fS6GotD41gmu5+HUJE1MJZzDlsDs6mL05zW/GYzmTUgMSlvMQ==", "e84e0efc-ca4d-4b29-ac79-7bc7f0be272a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be2c8be0-5a15-4165-8d10-f03b0d06cb14", null, "AQAAAAEAACcQAAAAEGF7keGpRsOfnGEYUuiu6mBla/Ok2T9BJn/PurLSst4RV6Rd08sW3ZtBakbsjIcEeQ==", "a557437c-e2c2-4faf-8ec0-76f1c9388e91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f56a7fc0-0c23-40ec-b60b-337426b6f768", null, "AQAAAAEAACcQAAAAEC5bcKEL5zNSj+o+/ofAHSD3pcZhXwDziBq6fC3J3itB+xa7sa0U5cpogfTNqC01ZA==", "b3a05e4e-e475-405f-b8ef-55ccaa6ee3c1" });
        }
    }
}
