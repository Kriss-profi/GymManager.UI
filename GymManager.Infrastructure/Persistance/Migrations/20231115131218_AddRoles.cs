using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManager.Infrastructure.Persistance.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1D3FF174-2637-4B36-82BF-86F894C9090D", "26B7CC9C-74D2-45D4-9FC2-BA22A045842D", "Pracownik", "PRACOWNIK" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "FE2AF78F-4353-4363-A6E6-3F1A9AD5331C", "2DD6F477-B941-4BCC-A943-F8A6C5D1F36C", "Klient", "KLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "FE740916-18C7-42AD-924C-273B76FEF837", "E2CE3CEA-BA77-4E87-BED8-BA46D7E6A776", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1D3FF174-2637-4B36-82BF-86F894C9090D");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "FE2AF78F-4353-4363-A6E6-3F1A9AD5331C");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "FE740916-18C7-42AD-924C-273B76FEF837");
        }
    }
}
