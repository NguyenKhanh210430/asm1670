using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook.Migrations
{
    public partial class asd12334541231 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApprove",
                table: "Categories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "101",
                column: "IsApprove",
                value: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "102",
                column: "IsApprove",
                value: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101",
                column: "ConcurrencyStamp",
                value: "98a56477-85ed-4a75-ba33-e644992f7246");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102",
                column: "ConcurrencyStamp",
                value: "eaaac3fa-9cde-40e8-94fa-701c8660b451");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103",
                column: "ConcurrencyStamp",
                value: "0d7ff7bd-0af1-4100-ace6-d284010987be");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "398827ec-d73e-42c3-8f5d-9eaa08943f05", "AQAAAAEAACcQAAAAEFoHtxx3UPib/gh/NFU9fFhP4PA+HNB9Q6UKhBHuzRwi+wO6xGSzDsF3snuhuQRi1A==", "70fa6b39-d9ff-4b7f-905e-767e51a23a4f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9eab5103-d0aa-4d0a-b209-d150fae2422c", "AQAAAAEAACcQAAAAEBdMQ2HivHk06rvTjMI+3edsAFgM36crBIsrqlCk1083kdTk18ZFZiQ3oaS4g/vnhw==", "8ac1f91d-08e3-4030-96ae-3804ba27fa1e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f33189f7-f69a-4041-81d2-5575bd57b63e", "AQAAAAEAACcQAAAAEGTKckk4NlmPNNheKW80xcnPw6fhHo87BbLChnftvOowJZofLXV0WE1EOQ3emrM2Ew==", "e2c40876-6653-4c95-aaea-2cdd3ecb7256" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6c04fe2-fd71-4d37-ae14-a477e773d7aa", "AQAAAAEAACcQAAAAECudt0UKyr82lxVihT9J3Ql6okEYqf38e+6EbO/kmKtF6HGILy2Io3tDIt+DPfayNQ==", "00ed9bdd-7e3d-4568-8d1e-d2a045cd9690" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApprove",
                table: "Categories");

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
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9f6f40a-98aa-419f-9074-9312067a71e0", "AQAAAAEAACcQAAAAEC9cCkJseGJSq1fxJtr2Wyt5tBvU01JiziJqGbY6XgGXunAmA6V1JWaZSCa3LC+f/A==", "8eb8fdd0-10f3-47b5-b25e-b706012564ef" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "572c1864-bcae-47ea-8365-849c04fe2f02", "AQAAAAEAACcQAAAAEOAf64m2B8lVvnoGbE1M40vdS3kfrhPfEh9i0jQtNOqS8uuk2a4rHF8v5RISHaFAhQ==", "9edde650-01ed-4b26-b2c3-92ab86d0fb7e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09b4fa4e-4b97-479e-881e-d8914470a3b7", "AQAAAAEAACcQAAAAELri18+F2uExg50YakljQD+HYqDDspfjTdh5wCMon832sBJNeMRTQEctGwK09w8q+A==", "bf940fa3-fba3-4303-9c87-f2fa47df764c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d924c61b-a9ea-4cde-92f9-34fcdc7e97a1", "AQAAAAEAACcQAAAAECii/iCw+h1SFHWJPmQ4EJO5KPt8PaE3Q2fMPA66PLgenwYqS5rRPZ3A8KYWOn/96A==", "b01f465c-4627-48ea-a152-2f9d3a36c0a8" });
        }
    }
}
