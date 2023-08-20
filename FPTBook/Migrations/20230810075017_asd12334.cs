using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook.Migrations
{
    public partial class asd12334 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "203", "103" });

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

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "203", "102" },
                    { "204", "103" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "203", "102" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "204", "103" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101",
                column: "ConcurrencyStamp",
                value: "a850e2fb-cd40-40e6-bfc2-b6206ee26256");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102",
                column: "ConcurrencyStamp",
                value: "f4f328cd-611b-4b32-8fa9-e5815583f340");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103",
                column: "ConcurrencyStamp",
                value: "23565952-0bee-42b8-a380-76e0d0fc40fc");

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "203", "103" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "375e3f8d-9eed-4135-a31d-49a7b620d3f8", "AQAAAAEAACcQAAAAEBzwJoyU5TrDJAhSoL/0BTY3FGfEPJOf99cLSxICCg2QxlfMpWQyvydPPbNPqUJ0bw==", "857c5acd-07fe-4224-8b2b-c2ac12ca49bd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7db965b3-7eb7-40ce-9526-28ae3212e058", "AQAAAAEAACcQAAAAEB/pAhR7VpNJUsJwvM570+N2S92d3NAtnjaEPmbv8S+xPcRIwbt6OZc968kcEAmnFA==", "f057ecea-093b-4e0d-91d7-51f09fd8bf52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf30d4ce-f067-4bec-a574-001f77f47691", "AQAAAAEAACcQAAAAEB13m9Mpl1jRvAQk7jR5GtCJBSk/ov/hcXULx3CEkJttkaUkf5A2AgIEUxwBDR6UCg==", "d927df79-dd9c-4f87-88ba-7274725b39c7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cf50586-5998-4499-96d4-febd45430888", "AQAAAAEAACcQAAAAED+DkrTvmCupuMcEGkpFnDJH+jN96msgadoxWkUUHNBWTtitJFyxu1MQLQx677kmWg==", "5520d401-584e-44b5-a4f5-779b2260f527" });
        }
    }
}
