using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101",
                column: "ConcurrencyStamp",
                value: "b2d67d93-f18e-4560-a93c-6ad398bb3dea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102",
                column: "ConcurrencyStamp",
                value: "c335b781-7f69-4a2c-b17b-9f2b68dfdf8a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103",
                column: "ConcurrencyStamp",
                value: "9c837c77-57fe-4bcc-9f9b-5d01a81a8e7f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0089946-6352-4e3d-a56b-e830b5585ff9", "AQAAAAEAACcQAAAAEI0b98yZ33kCSKBGVyyFFlQmNKa8D2NhBZ2oyEWwHLd9QmS5hRqBBO/bAMgZJbB4Pg==", "dd87c32c-cb10-4282-b3e7-87660fdfcf86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68aa84a8-30cd-451e-9768-8d0b53f6c738", "AQAAAAEAACcQAAAAEKFMYLUN8SETESaqRhWAB09IstdtDk8CB8rhdjxq/5721OrQFDtRmdhnkQZPfP6rmw==", "8b53ff22-8868-429f-859d-99440f3fdc71" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2c7ffd1-92d6-4207-8bff-408318aa2b6b", "AQAAAAEAACcQAAAAEC3Od1H3n8/+L/Z4DXoLpro58dyekYcKygO3gTLupyw7Q9+qvlIB5URW9V1xx1Ob+w==", "c2fe74fd-5a4a-4e86-bef5-362b6e3b7905" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a85f41e-f6c7-4272-8f11-72b459e44d0c", "AQAAAAEAACcQAAAAEKiXLGu2RzF5V/F15QGVN3ugx3+boYU8pbn14oaRaWof1UkuS18BmjdpWj2LfgeEbA==", "ad6dd020-4fb3-4b15-badb-522ae31b61e8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
