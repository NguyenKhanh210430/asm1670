using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook.Migrations
{
    public partial class NewUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_AppUserModelId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AppUserModelId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AppUserModelId",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "9780751565351231235",
                column: "Description",
                value: @"Based on an original new story by J.K. Rowling, Jack Thorne and John Tiffany, a new play by Jack Thorne.

Based on an original new story by J.K. Rowling, Jack Thorne and John Tiffany, a new play by Jack Thorne, Harry Potter and the Cursed Child is the eighth story in the Harry Potter series and the first official Harry Potter story to be presented on stage. The play will receive its world premiere in London’s West End on 30th July 2016. It was always difficult being Harry Potter and it isn’t much easier now that he is an overworked employee of the Ministry of Magic, a husband, and father of three school-age children. While Harry grapples with a past that refuses to stay where it belongs, his youngest son Albus must struggle with the weight of a family legacy he never wanted. As past and present fuse ominously, both father and son learn the uncomfortable truth: sometimes, darkness comes from unexpected places.");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "9780751565355",
                column: "Description",
                value: @"Based on an original new story by J.K. Rowling, Jack Thorne and John Tiffany, a new play by Jack Thorne.

Based on an original new story by J.K. Rowling, Jack Thorne and John Tiffany, a new play by Jack Thorne, Harry Potter and the Cursed Child is the eighth story in the Harry Potter series and the first official Harry Potter story to be presented on stage. The play will receive its world premiere in London’s West End on 30th July 2016. It was always difficult being Harry Potter and it isn’t much easier now that he is an overworked employee of the Ministry of Magic, a husband, and father of three school-age children. While Harry grapples with a past that refuses to stay where it belongs, his youngest son Albus must struggle with the weight of a family legacy he never wanted. As past and present fuse ominously, both father and son learn the uncomfortable truth: sometimes, darkness comes from unexpected places.");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "9781408708989",
                column: "Description",
                value: @"J.K. Rowling's screenwriting debut is captured in this exciting hardcover edition of the Fantastic Beasts and Where to Find Them screenplay.
When Magizoologist Newt Scamander arrives in New York, he intends his stay to be just a brief stopover. However, when his magical case is misplaced and some of Newt's fantastic beasts escape, it spells trouble for everyone...Fantastic Beasts and Where to Find Them marks the screenwriting debut of J.K. Rowling, author of the beloved and internationally bestselling Harry Potter books. Featuring a cast of remarkable characters, this is epic, adventure-packed storytelling at its very best. Whether an existing fan or new to the wizarding world, this is a perfect addition to any reader's bookshelf.");

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserID",
                table: "Orders",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserID",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserModelId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "9780751565351231235",
                column: "Description",
                value: @"Based on an original new story by J.K. Rowling, Jack Thorne and John Tiffany, a new play by Jack Thorne.

Based on an original new story by J.K. Rowling, Jack Thorne and John Tiffany, a new play by Jack Thorne, Harry Potter and the Cursed Child is the eighth story in the Harry Potter series and the first official Harry Potter story to be presented on stage. The play will receive its world premiere in London’s West End on 30th July 2016. It was always difficult being Harry Potter and it isn’t much easier now that he is an overworked employee of the Ministry of Magic, a husband, and father of three school-age children. While Harry grapples with a past that refuses to stay where it belongs, his youngest son Albus must struggle with the weight of a family legacy he never wanted. As past and present fuse ominously, both father and son learn the uncomfortable truth: sometimes, darkness comes from unexpected places.");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "9780751565355",
                column: "Description",
                value: @"Based on an original new story by J.K. Rowling, Jack Thorne and John Tiffany, a new play by Jack Thorne.

Based on an original new story by J.K. Rowling, Jack Thorne and John Tiffany, a new play by Jack Thorne, Harry Potter and the Cursed Child is the eighth story in the Harry Potter series and the first official Harry Potter story to be presented on stage. The play will receive its world premiere in London’s West End on 30th July 2016. It was always difficult being Harry Potter and it isn’t much easier now that he is an overworked employee of the Ministry of Magic, a husband, and father of three school-age children. While Harry grapples with a past that refuses to stay where it belongs, his youngest son Albus must struggle with the weight of a family legacy he never wanted. As past and present fuse ominously, both father and son learn the uncomfortable truth: sometimes, darkness comes from unexpected places.");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "9781408708989",
                column: "Description",
                value: @"J.K. Rowling's screenwriting debut is captured in this exciting hardcover edition of the Fantastic Beasts and Where to Find Them screenplay.
When Magizoologist Newt Scamander arrives in New York, he intends his stay to be just a brief stopover. However, when his magical case is misplaced and some of Newt's fantastic beasts escape, it spells trouble for everyone...Fantastic Beasts and Where to Find Them marks the screenwriting debut of J.K. Rowling, author of the beloved and internationally bestselling Harry Potter books. Featuring a cast of remarkable characters, this is epic, adventure-packed storytelling at its very best. Whether an existing fan or new to the wizarding world, this is a perfect addition to any reader's bookshelf.");

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserModelId",
                table: "Orders",
                column: "AppUserModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_AppUserModelId",
                table: "Orders",
                column: "AppUserModelId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
