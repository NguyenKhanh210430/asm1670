using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook.Migrations
{
    public partial class asd1233454123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101",
                column: "ConcurrencyStamp",
                value: "e3af3faa-cd85-4a6c-b9b1-e09550c67ff8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102",
                column: "ConcurrencyStamp",
                value: "a7d8d27c-0e64-4d9a-8fc1-acc8474c631e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103",
                column: "ConcurrencyStamp",
                value: "2c349b24-8372-4d40-91e9-4a397c74d075");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: "101",
                column: "StoreOwnerId",
                value: "202");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: "102",
                column: "StoreOwnerId",
                value: "203");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9f6f40a-98aa-419f-9074-9312067a71e0", "AQAAAAEAACcQAAAAEC9cCkJseGJSq1fxJtr2Wyt5tBvU01JiziJqGbY6XgGXunAmA6V1JWaZSCa3LC+f/A==", "8eb8fdd0-10f3-47b5-b25e-b706012564ef" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "572c1864-bcae-47ea-8365-849c04fe2f02", "Nguyen Van Store", "AQAAAAEAACcQAAAAEOAf64m2B8lVvnoGbE1M40vdS3kfrhPfEh9i0jQtNOqS8uuk2a4rHF8v5RISHaFAhQ==", "9edde650-01ed-4b26-b2c3-92ab86d0fb7e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09b4fa4e-4b97-479e-881e-d8914470a3b7", "Nguyen Van Store", "AQAAAAEAACcQAAAAELri18+F2uExg50YakljQD+HYqDDspfjTdh5wCMon832sBJNeMRTQEctGwK09w8q+A==", "bf940fa3-fba3-4303-9c87-f2fa47df764c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d924c61b-a9ea-4cde-92f9-34fcdc7e97a1", "Nguyen Van Customer", "AQAAAAEAACcQAAAAECii/iCw+h1SFHWJPmQ4EJO5KPt8PaE3Q2fMPA66PLgenwYqS5rRPZ3A8KYWOn/96A==", "b01f465c-4627-48ea-a152-2f9d3a36c0a8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Stores",
                keyColumn: "Id",
                keyValue: "101",
                column: "StoreOwnerId",
                value: "102");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: "102",
                column: "StoreOwnerId",
                value: "103");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c0b2c25-0592-4d89-abea-72f173d115cf", "AQAAAAEAACcQAAAAEEuSEuhr2H7Yu084j73f1XuHF6U3YJ2yiANK4SG2qyIBjaR8/hIIzh69/m3RRVpYZw==", "2ee8bf94-c1c9-4ecb-8eba-227b408a394f" });

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
    }
}
