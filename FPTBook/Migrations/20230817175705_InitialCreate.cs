using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101",
                column: "ConcurrencyStamp",
                value: "79064fc3-d9d0-473f-82cf-2055256e743e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102",
                column: "ConcurrencyStamp",
                value: "a8a1c4d8-c6f5-4471-ab72-61f424342bcf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103",
                column: "ConcurrencyStamp",
                value: "3fbf6b6f-8d7c-4505-909a-0f097da392fa");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f291d30-8f7a-4ac8-a223-bcc973457302", "AQAAAAEAACcQAAAAECQBEIasOqM8n3Thf6wVGfRLXD0VtcEESsVMloNWYRMv3p9Zsz8NTjF9A3q7AYyOng==", "8fac8f7f-6a1c-4ac2-acc8-a813fa136659" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54e2ac57-0709-400b-bb5d-525ee0477dce", "AQAAAAEAACcQAAAAENtrFfbXH1tkWFJD54aQDBDkGNEOmgizVa+u2g/isoc28n0r8ITr2pmoa/LLs3otFA==", "466331a4-0191-42a7-9a16-352315aabc07" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a98ac4b4-20a8-4400-9d13-6c599e2a44cd", "AQAAAAEAACcQAAAAEAwQSFgnr+FdfiBphrLhTZaj9qX+ECpDTGapAdrVkljh1lVuijqYK/u/JWwyDy/UJw==", "89a4b146-da25-4fd9-a3f2-2898596d6cc4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b8dc175-88b5-4b13-8d3b-beaeddb4298b", "AQAAAAEAACcQAAAAEGhBEgzMn9pUW6CtGimgaw7j/MScihItXAHrkO7V5Jn2yOzkiR+fqxVkFZ+cUMd3Qg==", "4d0a1c4e-ca0f-4d53-b714-106ff2bad8b3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101",
                column: "ConcurrencyStamp",
                value: "54367f34-286d-4bde-aae0-770f664c4ea1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102",
                column: "ConcurrencyStamp",
                value: "038c55ce-dbd1-416c-a59b-07a984ab3479");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103",
                column: "ConcurrencyStamp",
                value: "4facf98e-b0ea-48a4-b6b6-671a3c6f904e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "344ab1cb-b228-4dd4-a499-7a036f02d99d", "AQAAAAEAACcQAAAAEJq0eMvRAixkJ8qanwp44ykAo1YI5qwSUiNi8S2VI/hwAvNQJeoMlbGBW/iAd7gKWw==", "7f46a170-2e54-4db3-a76c-6f0cc211fd69" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c3b39cb-c916-46b6-b24d-80f99ab9baa6", "AQAAAAEAACcQAAAAECcMs8rnnPBR3KYkMXRm0fUZHI3ILBSNAXaDSuMgXM4tEe9uhHXA5IKp0pkyDoQUnw==", "86718405-7f30-40bb-beb1-9f92228fbfad" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec57c2f1-b291-4f37-9bee-5d3b12a83f44", "AQAAAAEAACcQAAAAEJ/VeaQZfzG/b3LhmkWEI3IXQNEMehSnefk2RAv1qg0U5xVlITfpJco2+rm1TKcW9A==", "0ff44286-a2b6-4913-9a92-cf2123d4b58a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c01b835-65ec-4f97-89d8-d99a13ebb588", "AQAAAAEAACcQAAAAEHFur2L8llMKAGTEhuoLFJQNQRu3znBPdJRhs6loUFKfAdc7O63O875YCcnO7I1ILA==", "27deadf0-18c1-4f0c-97ac-f1cda4695956" });
        }
    }
}
